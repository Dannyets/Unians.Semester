using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Unians.Semester.Data.Models;

namespace Unians.Semester.Data.Context
{
    public class SemesterDbContext : BaseMySqlDbContext
    {
        public SemesterDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            optionsBuilder.UseInMemoryDatabase("unians_semester");
        }

        public DbSet<DbSemester> Semesters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbSemester>().HasKey(p => p.Id);

            modelBuilder.Entity<DbSemester>().HasIndex(p => p.UniversityId);

            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            AddInitialData(modelBuilder);
        }

        private void AddInitialData(ModelBuilder modelBuilder)
        {
            var semester = new DbSemester
            {
                Id = 1,
                UniversityId = 1,
                Name = "חורף 2019",
                CreatedAt = DateTime.UtcNow,
                LastUdpatedAt = DateTime.UtcNow
            };

            var semesters = new List<DbSemester> { semester };

            modelBuilder.Entity<DbSemester>().HasData(semesters);
        }
    }
}
