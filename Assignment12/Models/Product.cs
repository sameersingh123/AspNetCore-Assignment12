using System.ComponentModel.DataAnnotations;

namespace Assignment12.Models
{
    public class Product
    {
        [Required(ErrorMessage = "{0} must be supplied")]
        [Range(1, int.MaxValue,ErrorMessage ="{0} should be a valid number")]
        public int? ProductCode { get; set; }



        [Required(ErrorMessage = "{0} must be supplied")]
        [Range(1, double.MaxValue,ErrorMessage ="{0} should be valid number")]
        public double? Price { get; set; }



        [Required(ErrorMessage = "{0} must be supplied")]
        [Range(1,int.MaxValue, ErrorMessage ="{0} should be a valid number")]
        public int? Quantity { get; set; }

    }
}
