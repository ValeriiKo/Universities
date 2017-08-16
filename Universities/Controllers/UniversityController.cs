using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;

namespace Universities.Controllers
{
    public class UniversityController : Controller
    {
        private IUniversityRepository repository;
        public UniversityController(IUniversityRepository universityRepository)// for Ninject
        {
            this.repository = universityRepository;
        }

        public ViewResult List()
        {
            return View(repository.Universities);
        }
    }
}