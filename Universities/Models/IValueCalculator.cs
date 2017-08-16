using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universities.Models
{
    public interface IValueCalculator
    {
        int ValueStudents(IEnumerable<University> universities);
    }
}