using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.DataAccess.Context;
using TravelAgency.DataAccess.Interfaces;

namespace TravelAgency.DataAccess.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ICityRepository Cities { get; private set; }
        public ICountryRepository Countries { get; private set; }
        public IStatusRepository Statuses { get; private set; }
        public IRatingRepository Ratings { get; private set; }
        public ITransporterRepository Transporters { get; private set; }
        public ITripRepository Trips { get; private set; }
        public IApplicationUserRepository ApplicationUsers { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Cities = new CitiesRepository(context);
            Countries = new CountryRepository(context);
            Statuses = new StatusRepository(context);
            Ratings = new RatingRepository(context);
            Transporters = new TransporterRepository(context);
            Trips = new TripRepository(context);
            ApplicationUsers = new ApplicationUserRepository(context);


        }

     

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
