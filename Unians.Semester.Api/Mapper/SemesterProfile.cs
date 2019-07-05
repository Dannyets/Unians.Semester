using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Semester.Api.Data.Models;
using Unians.Semester.Data.Models;

namespace Unians.Semester.Api.Mapper
{
    public class SemesterProfile : Profile
    {
        public SemesterProfile()
        {
            CreateMap<ApiSemester, DbSemester>().ReverseMap();
        }
    }
}
