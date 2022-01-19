using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SM.Application;
namespace SM.Application.Contracts.ProductCategory
{
    public class CreateProductCategory
    {
        [Required(ErrorMessage = ValidationMassage.IsRequired)]
        [MaxLength(255,ErrorMessage = ValidationMassage.MaxLenth)]
        [MinLength(3,ErrorMessage = ValidationMassage.MinLenth)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = ValidationMassage.IsRequired)]
        public string Slug { get; set; }
        public IFormFile CategoryPicture { get; set; }
    }
}
