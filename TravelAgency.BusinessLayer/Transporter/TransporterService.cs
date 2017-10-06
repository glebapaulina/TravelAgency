using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;
using TravelAgency.DataAccess.Repositories;

namespace TravelAgency.BusinessLayer.Transporter
{
    public class TransporterService : BaseService<DataAccess.Models.Transporter, TransporterViewModel>, ITransporterService
    {
        public TransporterService(TransporterRepository repository)
            :base(repository)
        {
            
        }
    }
}