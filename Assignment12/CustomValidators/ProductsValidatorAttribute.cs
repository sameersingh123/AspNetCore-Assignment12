using Assignment12.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Assignment12.CustomValidators
{
    public class ProductsValidatorAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                List<Product> products = (List<Product>)value;
                if (products.Count == 0)
                {
                    return new ValidationResult("Minimum products should be 1");
                }
                else
                {
                    return ValidationResult.Success;
                }

            }
            return null;
        }
    }
}
