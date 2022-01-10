using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Contract.Account
{
    public interface IAccountApplication
    {
        void Create(CreateAccount commend);
        void Edit(EditAccount commend);
        List<AccountViewModel> List(AccountSearchModel commend);
        void ChangePassword(ChangePasswordModel commend);
        void Removed(long Id);
        void Active(long Id);
        EditAccount GetValueForEdit(long Id);
    }
}
