using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Universities.Infrastructure;

namespace Universities
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
