using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unians.Semester.Data.Interfaces;
using Unians.Semester.Data.Models;

namespace Unians.Semester.Data.Repositories
{
    public class SemestersRepository : BaseEntityFrameworkCoreRepository<DbSemester>, ISemesterRepository
    {
        public SemestersRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<DbSemester>> GetSemestersForUniversity(int universityId)
        {
            return await _dbSet.Where(s => s.UniversityId == universityId).ToListAsync();
        }
    }
}
