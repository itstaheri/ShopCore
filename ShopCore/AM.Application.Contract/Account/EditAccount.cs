using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Contract.Account
{
    public class EditAccount : CreateAccount
    {
        public long Id { get; set; }
    }
}
