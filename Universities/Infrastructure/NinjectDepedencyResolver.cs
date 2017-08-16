using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using System.Configuration;
using Domain.Concrete;
using Domain.Abstract;

namespace Universities.Infrastructure
{
    public class NinjectControllerFactory: DefaultControllerFactory
    {
        private IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }

        private void AddBindings()
        {
            kernel.Bind<IUniversityRepository>().To<EFUniversityRepository>();
        }
    }
}