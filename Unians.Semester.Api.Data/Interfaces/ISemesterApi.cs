using AspNetCore.Infrastructure.Controllers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unians.Semester.Api.Data.Models;

namespace Unians.Semester.Api.Data.Interfaces
{
    public interface ISemesterApi : ICrudApi<ApiSemester>
    {
        Task<ActionResult<IEnumerable<ApiSemester>>> GetSemestersForUniversity(int universityId);
    }
}
