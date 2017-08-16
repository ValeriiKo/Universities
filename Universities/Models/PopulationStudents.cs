using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universities.Models
{
    public class PopulationStudents
    {
        private IValueCalculator calc;
        public PopulationStudents(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<University> Universities { get; set; }
        public int CalculateTotalStudents()
        {
            return calc.ValueStudents(Universities);
        }
    }
}