using System.ComponentModel.DataAnnotations;

namespace Assignment12.CustomValidators
{
    public class MinimumYearValidatorAttribute:ValidationAttribute
    {
        public DateTime MinDate { get; set; }
        public MinimumYearValidatorAttribute(string mindate)
        {
            MinDate = Convert.ToDateTime(mindate);

        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime Date = (DateTime)value;    //user Input Date(In Request)
                if (Date<MinDate)
                {
                    return new ValidationResult($"Order date should be greater than {MinDate}");
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
