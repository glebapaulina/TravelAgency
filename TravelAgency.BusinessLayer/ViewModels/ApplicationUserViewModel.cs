using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.BusinessLayer.ViewModels
{
    public class ApplicationUserViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int  Type { get; set; }
        public virtual ICollection<DataAccess.Models.Trip> Trips { get; set; }
    }
}