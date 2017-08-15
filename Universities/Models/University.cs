using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universities.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Rank { get; set; }
        public int NumberOfStudents { get; set; }
        public double InternationalStudent { get; set; } //in percent!

    }
}