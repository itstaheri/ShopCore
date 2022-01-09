using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks
{
    public class FileExtentionLimited : ValidationAttribute, IClientModelValidator
    {
        private readonly string[] _valiExtention;

        public FileExtentionLimited(string[] valiExtention)
        {
            _valiExtention = valiExtention;
        }
        public override bool IsValid(object value)
        {
            var file = value as IFormFile;
            if (file == null) return true;
            var fileExtention = Path.GetExtension(file.FileName);
            return _valiExtention.Contains(fileExtention);
        }
        public void AddValidation(ClientModelValidationContext context)
        {
            //context.Attributes.Add("val-data","true");
            context.Attributes.Add("data-val-fileExtentionLimited", ErrorMessage);
        }
    }
}
