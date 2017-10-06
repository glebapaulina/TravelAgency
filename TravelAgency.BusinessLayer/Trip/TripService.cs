using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Repositories;

namespace TravelAgency.BusinessLayer.Trip
{
    public class TripService : BaseService<DataAccess.Models.Trip, TripViewModel>, ITripService
    {
        public TripService(TripRepository repository)
            :base(repository)
        {
            
        }
    }
}