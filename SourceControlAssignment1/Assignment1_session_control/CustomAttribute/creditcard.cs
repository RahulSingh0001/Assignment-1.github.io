using System.ComponentModel.DataAnnotations;

namespace FormValidation.CustomAttribute
{
    public class creditcard : ValidationAttribute
    {
        private int _limit;
        public creditcard(int value)
        {
            _limit = value;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (value is int)
                {
                    int digits = (int)value;
                    if (digits < _limit)
                    {
                        return new ValidationResult("Minimum age must be " + _limit);
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}