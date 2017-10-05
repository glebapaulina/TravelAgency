using System;
using System.Collections.Generic;
using log4net;
using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Interfaces;

namespace TravelAgency.BusinessLayer.City
{
    public class CityService : BaseService<DataAccess.Models.City, CityViewModel>, ICityService
    {
        public CityService(ICityRepository repository)
            : base(repository)
        {

        }

    }

}