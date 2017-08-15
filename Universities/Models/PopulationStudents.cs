using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universities.Models
{
    public class PopulationStudents
    {
        private LinqValueCalculator calc;
        public PopulationStudents(LinqValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<University> Universities { get; set; }
        public double CalculateTotalStudents()
        {
            return calc.ValueStudents(Universities);
        }
    }
}