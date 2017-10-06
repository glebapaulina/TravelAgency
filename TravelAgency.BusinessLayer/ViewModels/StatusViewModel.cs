using System.ComponentModel.DataAnnotations;

namespace TravelAgency.BusinessLayer.ViewModels
{
    public class StatusViewModel
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

    }
}