using GetExercises.Web.DAL;
using GetExercises.Web.DAL.Interfaces;
using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GetExercises.Web
{
    // Setting up the application after including Ninject and Ninject.MVC5
    // https://stackoverflow.com/questions/47001124/web-api2-ninjectwebcommon-cs-do-not-appear/47002329#47002329
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }    

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=DvdStore;Integrated Security=True"; 

            kernel.Bind<IFilmDAL>().To<FilmDAL>().WithConstructorArgument("connectionString", connectionString);
            kernel.Bind<IActorDAL>().To<ActorDAL>().WithConstructorArgument("connectionString", connectionString);
            kernel.Bind<ICustomerDAL>().To<CustomerDAL>().WithConstructorArgument("connectionString", connectionString);

            return kernel;
        }
    }
}
