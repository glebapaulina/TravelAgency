using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;

namespace TravelAgency.BusinessLayer.Status
{
    public interface IStatusService : IBaseService<DataAccess.Models.Status, StatusViewModel>
    {
        
    }
}