using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;

namespace TravelAgency.BusinessLayer.Trip
{
    public interface ITripService : IBaseService<DataAccess.Models.Trip, TripViewModel>                                                                     
    {
        
    }
}