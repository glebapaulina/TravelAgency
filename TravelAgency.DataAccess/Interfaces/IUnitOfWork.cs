using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataAccess.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        //Exposing repostiories
         //IEnityNameRepository EntityName {get;}
        ICityRepository Cities { get; }
        ICountryRepository Countries { get; }
        IStatusRepository Statuses { get; }
        IRatingRepository Ratings { get; }     
        ITransporterRepository Transporters { get; }
        ITripRepository Trips { get; }

        IApplicationUserRepository ApplicationUsers { get; }

        void Complete();
    }
}
