using AM.Application.Contract.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Account
{
    public interface IAccountQueryRepository
    {
        AccountQueryViewModel GetProfileItems(long UserId);
        void EditAddress(AddressQueryViewModel commend);
        AddressQueryViewModel GetValueForEditAddress(long Id);
     
     
    }
}
