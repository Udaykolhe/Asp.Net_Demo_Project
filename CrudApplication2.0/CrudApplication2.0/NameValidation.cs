using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudApplication2._0
{
    public class NameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid (object value, ValidationContext validationContext)
        {
            if (value !=null)
            {
                string message = value.ToString();
                if (message.Contains("a"))
                {
                    return ValidationResult.Success;
                }
                
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field Must contain";
            return new ValidationResult(ErrorMessage);
        }
    }
}