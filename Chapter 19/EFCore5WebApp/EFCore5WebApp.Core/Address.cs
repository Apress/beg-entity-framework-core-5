using System.ComponentModel.DataAnnotations;

namespace EFCore5WebApp.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name = "Address Line 1")]
        [Required]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Display(Name = "Zip Code")]
        [Required]
        public string ZipCode { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
