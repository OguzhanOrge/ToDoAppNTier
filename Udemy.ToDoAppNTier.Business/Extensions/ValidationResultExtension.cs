using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Common.ResponseObject;

namespace Udemy.ToDoAppNTier.Business.Extensions
{
    public static class ValidationResultExtension
    {
        public static List<CustomValidaitonError> ConvertToCustomValidationError(this ValidationResult validationResult)
        {
            List<CustomValidaitonError> errors = new();
            foreach (var error in validationResult.Errors) 
            {
                errors.Add(new()
                {
                    ErrorMessage = error.ErrorMessage,
                    PropertyName = error.PropertyName,
                });
            }
            return errors;
        }
    }
}
