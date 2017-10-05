using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.DataAccess.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }      
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Transporter> Transporters { get; set; }
        public DbSet<Trip> Trips { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}