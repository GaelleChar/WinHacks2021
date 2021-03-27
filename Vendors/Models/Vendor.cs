using System.ComponentModel.DataAnnotations;

namespace Vendors.Models
{
    public class Vendor{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string OpperatingHours { get; set; }
        [Required]
        public string PhoneNumber{get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Menu { get; set; }
        [Required]
        public string TakeoutOrCurbside {get; set;}
        
    }
}

//This application will provide operating hours, contact info, menu/specials available, prices.
