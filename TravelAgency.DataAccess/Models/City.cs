using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataAccess.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        [Required]
        public virtual Country Country { get; set; }


    }
}
