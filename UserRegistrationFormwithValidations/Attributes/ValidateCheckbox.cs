using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationFormwithValidations.Attributes
{
    public class ValidateCheckbox : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-chkbox", ErrorMessage);
        }

        public override bool IsValid(object? value)
        {
            if ((bool)value == true) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
