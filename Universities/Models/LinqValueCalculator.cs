using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universities.Models
{
    public class LinqValueCalculator: IValueCalculator
    {
        public int ValueStudents(IEnumerable<University> universities)
        {
            return universities.Sum(p => p.NumberOfStudents);
        }
    }
}