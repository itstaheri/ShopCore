using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AM.Application.Contract.Account
{
    public class CreateAccount
    {
       
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public string Number { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public IFormFile Picture { get; set; }
    }
}
 