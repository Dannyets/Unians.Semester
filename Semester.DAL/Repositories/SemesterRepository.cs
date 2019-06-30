using BaseRepositories.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Semester.DAL.Interfaces;
using Semester.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Semester.DAL.Repositories
{
    public class SemesterRepository : BaseEntityFrameworkCoreRepository<SemesterDbModel>, ISemesterRepository
    {
        public SemesterRepository(SemesterDbContext dbContext) : base(dbContext)
        {
        }
    }
}
