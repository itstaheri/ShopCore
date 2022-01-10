using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Contract.Account
{
    public class AccountViewModel
    {
        public long Id { get;  set; }
        public string FullName { get;  set; }
        public string Username { get;  set; }
        public string Password { get;  set; }
        public long RoleId { get;  set; }
        public string Number { get;  set; }
        public string ProfilePicture { get;  set; }
        public string Email { get;  set; }
        public bool IsRemoved { get;  set; }
        public string SignupDate { get;  set; }
        public string RoleName { get; set; }
    }
}
