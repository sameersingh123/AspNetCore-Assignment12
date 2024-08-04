using Assignment12.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace Assignment12.Models
{
    public class Order
    {
       
        public int? OrderNo { get; set; }

        [Required(ErrorMessage = "{0} must be supplied")]
        [MinimumYearValidator("2001-01-01")]
        public DateTime? OrderDate { get; set; }

        [Required(ErrorMessage = "{0} must be supplied")]
        [Range(1,double.MaxValue,ErrorMessage ="{0} should be valid number")]
        [InvoicePriceValidator]
        public double? InvoicePrice { get; set; }

        [ProductsValidator]
        public List<Product> Products { get; set; }=new List<Product>();

    }
}
