using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unians.Semester.Data.Models
{
    public class DbSemester : DbIdEntity
    {
        public int UniversityId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
