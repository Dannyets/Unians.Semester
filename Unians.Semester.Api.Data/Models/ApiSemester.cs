using System;
using System.Collections.Generic;
using System.Text;

namespace Unians.Semester.Api.Data.Models
{
    public class ApiSemester
    {
        public int Id { get; set; }

        public int UniversityId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
