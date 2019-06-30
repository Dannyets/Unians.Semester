using BaseRepositories.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Semester.DAL.Models;
using System;

namespace Semester.DAL
{
    public class SemesterDbContext : BaseMySqlDbContext
    {
        public DbSet<SemesterDbModel> Semesters { get; set; }

        public SemesterDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SemesterDbModel>().HasKey(p => p.Id);
        }
    }
}
