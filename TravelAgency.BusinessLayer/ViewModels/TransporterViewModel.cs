using System.ComponentModel.DataAnnotations;

namespace TravelAgency.BusinessLayer.ViewModels
{
    public class TransporterViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}