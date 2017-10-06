using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using TravelAgency.App_Start;
using TravelAgency.BusinessLayer.Country;
using TravelAgency.Controllers.Api;
using TravelAgency.DataAccess;

namespace TravelAgency
{
    public class IoCConfig
    {
        public static void ConfigureDependencyInjection()
        {

            var builder = new ContainerBuilder();
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterControllers(typeof(TripsController).Assembly);
            //builder.RegisterApiControllers(typeof(TripsController).Assembly);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

         


            builder.RegisterModule(new BussinessLayerAutofacModule());
            builder.RegisterModule(new DataAccessAutofacModule());
            builder.RegisterModule(new AutofacLoggingModule());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(typeof(TripsController).Assembly);
            var container = builder.Build();
          
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}