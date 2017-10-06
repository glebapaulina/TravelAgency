using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Interfaces;

namespace TravelAgency.BusinessLayer.Rating
{
    public class RatingService : BaseService<DataAccess.Models.Rating, RatingViewModel>, IRatingService
    {

        public RatingService(IRatingRepository repository)
            : base(repository)
        {
            
        }

    }
}