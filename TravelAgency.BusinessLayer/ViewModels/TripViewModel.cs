using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.BusinessLayer.ViewModels
{
    public class TripViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public virtual DataAccess.Models.Status Status { get; set; }

        [Required]
        public virtual DataAccess.Models.City City { get; set; }
        public virtual ICollection<DataAccess.Models.ApplicationUser> ApplicationUsers { get; set; }
        public virtual ICollection<DataAccess.Models.Rating> Ratings { get; set; }

        [Required]
        public virtual ICollection<DataAccess.Models.Transporter> Transporters { get; set; }
    }
}