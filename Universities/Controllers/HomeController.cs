using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universities.Models;
using Ninject;

namespace Universities.Controllers
{
    public class HomeController : Controller
    {
        private University[] universities =
        {
            new University{Name="University of Oxford", Country="United Kingdom",
                Rank =1, NumberOfStudents=19718, InternationalStudent=35},
            new University{Name="California Institute of Technology", Country="United States",
                Rank =2, NumberOfStudents=2181, InternationalStudent=27},
            new University{Name="Stanford University", Country="United States",
                Rank =3, NumberOfStudents=15658, InternationalStudent=22},
            new University{Name="University of Cambridge", Country="United Kingdom",
                Rank =4, NumberOfStudents=18605, InternationalStudent=35},
            new University{Name="Massachusetts Institute of Technology", Country="United States",
                Rank =5, NumberOfStudents=11192, InternationalStudent=34}
        };

        private IValueCalculator calc;

        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
            PopulationStudents cart = new PopulationStudents(calc) {Universities=universities};
            int totalStudents = cart.CalculateTotalStudents();
            return View(totalStudents);
        }
    }
}