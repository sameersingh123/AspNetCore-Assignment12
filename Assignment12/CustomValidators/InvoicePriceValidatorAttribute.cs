using Assignment12.Models;
using System.ComponentModel.DataAnnotations;

namespace Assignment12.CustomValidators
{
    public class InvoicePriceValidatorAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (validationContext.ObjectInstance is Order order)
            {
                double? CalculatedTotal = order.Products.Sum(p => p.Price * p.Quantity);
                if (order.InvoicePrice != CalculatedTotal)
                {
                    return new ValidationResult($"Invoice Price should be equal to total cost of the products: {CalculatedTotal} ");
                }
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid order object.");


       }    
        
    }
}
