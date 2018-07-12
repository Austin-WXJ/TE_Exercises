using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SSGeek
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        
        // Configure the dependency injection container.
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            // Set up the bindings
            //kernel.Bind<IInterface>.To<Class>();

            return kernel;
        }
    }
}
