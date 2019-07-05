using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unians.Semester.Data.Models;

namespace Unians.Semester.Data.Interfaces
{
    public interface ISemesterRepository : IEfRepository<DbSemester>
    {
        Task<IEnumerable<DbSemester>> GetSemestersForUniversity(int universityId);
    }
}
