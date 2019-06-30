﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BaseRepositories.EntityFrameworkCore.MySql;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Semester.DAL;
using Semester.DAL.Interfaces;
using Semester.DAL.Repositories;
using Swashbuckle.AspNetCore.Swagger;

namespace Semester.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<ISemesterRepository, SemesterRepository>();

            services.AddDbContext<SemesterDbContext>();

            services.AddSwaggerGen(options =>
            {
                var info = new Info
                {
                    Title = "Semester Web Api",
                    Version = "Vesrion 1",
                    Contact = new Contact
                    {
                        Name = "Danny Etsebban",
                        Email = "dannyets@gmail.com"
                    }
                };

                options.SwaggerDoc("v1", info);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            MySqlDbHelper.MigrateDatabase<SemesterDbContext>(serviceProvider);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Semester Web Api");
            });

            app.UseMvc();
        }
    }
}