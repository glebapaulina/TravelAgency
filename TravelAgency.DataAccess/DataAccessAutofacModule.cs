using System.Data.Entity;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Repositories;
using Autofac;
using Microsoft.AspNet.Identity.EntityFramework;
using TravelAgency.DataAccess.Context;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.DataAccess
{
    public class DataAccessAutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>()
                .AsSelf()
                .As<IdentityDbContext<ApplicationUser>>()
                .As<DbContext>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().InstancePerRequest();
            builder.RegisterType<CityRepository>().As<ICityRepository>().InstancePerRequest();
            builder.RegisterType<RatingRepository>().As<IRatingRepository>().InstancePerRequest();
            builder.RegisterType<StatusRepository>().As<IStatusRepository>().InstancePerRequest();
            builder.RegisterType<TransporterRepository>().As<ITransporterRepository>().InstancePerRequest();
            builder.RegisterType<TripRepository>().As<ITripRepository>().InstancePerRequest();


        }

    }  
}