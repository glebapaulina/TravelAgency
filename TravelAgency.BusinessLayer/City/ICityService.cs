using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;

namespace TravelAgency.BusinessLayer.City
{
    public interface ICityService : IBaseService<DataAccess.Models.City, CityViewModel>
    {
       
    }
}
