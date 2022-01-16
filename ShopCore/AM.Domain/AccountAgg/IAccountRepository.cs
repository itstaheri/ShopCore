using AM.Application.Contract.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.AccountAgg
{
    public interface IAccountRepository
    {
        void Create(AccountModel commend);
        List<AccountViewModel> GetAll(AccountSearchModel commend);
        AccountModel GetBy(long Id);
        void Save();
        bool Exist(string Username,string Email,string Number);
        AccountModel GetByUsername(string Username);
    }
}
