using System.ComponentModel.DataAnnotations;

namespace Banking.Web.Shared.Models
{
    public class Customer
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "'Initial Credit' must be greater than or equal 0.")]
        public decimal InitialCredit { get; set; }
    }
}
