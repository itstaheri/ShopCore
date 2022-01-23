using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Account
{
    public class AccountQueryViewModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Picture { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public AddressQueryViewModel Address { get; set; }
        public List<OrderQueryViewModel> Orders { get; set; }
   

    }
}
