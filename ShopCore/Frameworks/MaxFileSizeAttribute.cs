using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Frameworks
{
    public class MaxFileSizeAttribute : ValidationAttribute , IClientModelValidator
    {
        private readonly int _MaxFileSize;

        public MaxFileSizeAttribute(int maxFileSize)
        {
            _MaxFileSize = maxFileSize;
        }
     
        public override  bool IsValid(object Value)
        {
            var file = Value as IFormFile;
            if (file == null) return true;
            return file.Length < _MaxFileSize;
               
        }
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-maxFileSize ", ErrorMessage);
        }

    }
}
