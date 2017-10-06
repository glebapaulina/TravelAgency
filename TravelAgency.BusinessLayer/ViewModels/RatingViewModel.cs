using System;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.BusinessLayer.ViewModels
{
    public class RatingViewModel
    {
        public int Id { get; set; }

        [Required]
        public int Value { get; set; }

        [StringLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}