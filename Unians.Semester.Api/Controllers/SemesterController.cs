using AspNetCore.Infrastructure.Controllers;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Semester.Api.Data.Interfaces;
using Unians.Semester.Api.Data.Models;
using Unians.Semester.Data.Interfaces;
using Unians.Semester.Data.Models;

namespace Unians.Semester.Api.Controllers
{
    public class SemesterController : BaseEfCrudController<ApiSemester, DbSemester>, ISemesterApi
    {
        private readonly ISemesterRepository _repository;

        public SemesterController(ISemesterRepository repository, 
                                  IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiSemester>>> GetSemestersForUniversity(int universityId)
        {
            var semsters = await _repository.GetSemestersForUniversity(universityId);

            return Ok(semsters);
        }
    }
}
