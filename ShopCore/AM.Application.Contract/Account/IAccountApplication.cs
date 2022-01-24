using Framework;
using Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Contract.Account
{
    public interface IAccountApplication
    {
        OperationResult Register(Register commend);
        void Edit(EditAccount commend);
        List<AccountViewModel> List(AccountSearchModel commend);
        void ChangePassword(ChangePasswordModel commend);
        void Removed(long Id);
        void Active(long Id);
        EditAccount GetValueForEdit(long Id);
        OperationResult Login(Login commend);
        void Logout();
        void UserChangePassword(ChangePasswordModel commend);
    }
}
