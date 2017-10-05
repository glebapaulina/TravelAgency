using System.Collections.Generic;
using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Repositories;


namespace TravelAgency.BusinessLayer.Country
{
    public interface ICountryService : IBaseService<DataAccess.Models.Country, CountryViewModel>
    {
    
    }
}