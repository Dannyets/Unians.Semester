using BaseRepositories.EntityFrameworkCore.Models.Interfaces;
using Semester.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Semester.DAL.Interfaces
{
    public interface ISemesterRepository : IEfRepository<SemesterDbModel>
    {

    }
}
