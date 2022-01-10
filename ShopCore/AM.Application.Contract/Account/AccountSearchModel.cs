using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Contract.Account
{
    public class AccountSearchModel
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
    }
}
