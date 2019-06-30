using AspNetCore.Infrastructure.Controllers;
using AutoMapper;
using BaseRepositories.EntityFrameworkCore.Models.Interfaces;
using Semester.Api.Models;
using Semester.DAL.Interfaces;
using Semester.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semester.Api.Controllers
{
    public class SemesterController : BaseEfCrudController<SemesterApiModel, SemesterDbModel>
    {
        private readonly ISemesterRepository _repository;

        public SemesterController(ISemesterRepository repository,
                                  IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
