using AspNetCore.Infrastructure.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Semester.Api.Data.Models;
using Unians.Semester.Data.Interfaces;
using Unians.Semester.Data.Models;

namespace Unians.Semester.Api.Controllers
{
    public class SemesterController : BaseEfCrudController<ApiSemester, DbSemester>
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
            var dbSemsters = await _repository.GetSemestersForUniversity(universityId);

            var apiSemesters = dbSemsters.Select(s => _mapper.Map<ApiSemester>(s));

            return Ok(apiSemesters);
        }
    }
}
