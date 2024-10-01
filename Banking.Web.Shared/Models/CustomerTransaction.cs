using System.ComponentModel.DataAnnotations;

namespace Banking.Web.Shared.Models
{
    public class CustomerTransaction
    {
        [Required]
        public string CustomerId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "'Initial Credit' must be greater than or equal 0")]
        public decimal InitialCredit { get; set; }
    }
}
