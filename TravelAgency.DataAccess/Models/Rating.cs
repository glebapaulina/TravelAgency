using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.DataAccess.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int Value { get; set; }

        [StringLength(1000)]
        public string Comment { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
