using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using log4net;
using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;


namespace TravelAgency.BusinessLayer.Country

{
    public class CountryService : BaseService<DataAccess.Models.Country, CountryViewModel>, ICountryService
    {
        public CountryService(ICountryRepository repository)
            :base(repository)
        {
            
        }

    }

   
}