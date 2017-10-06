using System.Reflection;
using Autofac;
using TravelAgency.BusinessLayer.City;
using TravelAgency.BusinessLayer.Country;
using TravelAgency.BusinessLayer.Rating;
using TravelAgency.BusinessLayer.Status;
using TravelAgency.BusinessLayer.Transporter;
using TravelAgency.BusinessLayer.Trip;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Repositories;

namespace TravelAgency
{
    public class BussinessLayerAutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CountryService>().As<ICountryService>().InstancePerRequest();
            builder.RegisterType<CityService>().As<ICityService>().InstancePerRequest();
            builder.RegisterType<RatingService>().As<IRatingService>().InstancePerRequest();
            builder.RegisterType<StatusService>().As<IStatusService>().InstancePerRequest();
            builder.RegisterType<TransporterService>().As<ITransporterService>().InstancePerRequest();
            builder.RegisterType<TripService>().As<ITripService>().InstancePerRequest();





        }

    }
}