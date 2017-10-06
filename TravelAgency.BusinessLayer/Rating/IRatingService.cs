using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;

namespace TravelAgency.BusinessLayer.Rating
{
    public interface IRatingService : IBaseService<DataAccess.Models.Rating, RatingViewModel>
    {
        
    }
}