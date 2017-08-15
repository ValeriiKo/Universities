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
        public int YearEstablishment { get; set; }
        public int Description { get; set; }
    }
}