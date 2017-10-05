using TravelAgency.DataAccess.Models;
using AutoMapper;
using TravelAgency.BusinessLayer.ViewModels;


namespace TravelAgency
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Country, CountryViewModel>().ReverseMap();
            });
        
        }

    }
}