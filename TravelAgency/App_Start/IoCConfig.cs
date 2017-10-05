using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using log4net;
using TravelAgency.BusinessLayer.Country;
using TravelAgency.DataAccess.Context;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;
using TravelAgency.DataAccess.Repositories;

namespace TravelAgency.App_Start
{
    public class IoCConfig
    {
        public static void ConfigureDependencyInjection()
        {

            var builder = new ContainerBuilder();
           

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<ApplicationDbContext>().InstancePerLifetimeScope();

            builder.RegisterTypes()
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            //builder.RegisterTypes()
            //    .Where(t => t.Name.EndsWith("Service"))
            //    .AsImplementedInterfaces()
            //    .InstancePerRequest();

            builder.RegisterType<CountryRepository>().As<ICountryRepository>().InstancePerRequest();
            builder.RegisterType<CountryService>().As<ICountryService>().InstancePerRequest();
            builder.RegisterModule(new AutofacLoggingModule());
            var container = builder.Build();
          
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}