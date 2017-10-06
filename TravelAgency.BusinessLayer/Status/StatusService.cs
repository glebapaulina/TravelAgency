using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Interfaces;

namespace TravelAgency.BusinessLayer.Status
{
    public class StatusService : BaseService<DataAccess.Models.Status, StatusViewModel>, IStatusService
    {
        public StatusService(IStatusRepository repository)
            :base(repository)
        {
            
        }
    }
}