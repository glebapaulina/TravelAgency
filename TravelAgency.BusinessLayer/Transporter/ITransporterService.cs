using TravelAgency.BusinessLayer.Base;
using TravelAgency.BusinessLayer.ViewModels;

namespace TravelAgency.BusinessLayer.Transporter
{
    public interface ITransporterService : IBaseService<DataAccess.Models.Transporter, TransporterViewModel>
    {
        
    }
}