using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Management_System.Models
{
    public class customer
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

    }
}
