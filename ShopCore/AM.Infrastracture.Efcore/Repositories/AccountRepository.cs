using AM.Application.Contract.Account;
using AM.Domain.AccountAgg;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AM.Infrastracture.Efcore.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountContext _context;

        public AccountRepository(AccountContext context)
        {
            _context = context;
        }

        public void Create(AccountModel commend)
        {
            _context.accounts.Add(commend);
            _context.SaveChanges();
        }

        public AccountModel GetBy(long Id)
        {
            return  _context.accounts.SingleOrDefault(x => x.Id == Id);
           
        }

        public List<AccountViewModel> GetAll(AccountSearchModel commend)
        {
            var query = _context.accounts.Include(x=>x.role).Select(x => new AccountViewModel
            {
                Id = x.Id,
                SignupDate = DateTime.Now.ToFarsi(),
                Email = x.Email,
                FullName =x.FullName,
                IsRemoved = x.IsRemoved,
                Number = x.Number,
                Password = x.Password,
                ProfilePicture = x.ProfilePicture,
                RoleId = x.RoleId,
                Username = x.Username,
                RoleName = x.role.Name
                
            }).ToList();

            if (commend!=null)
            {
                if (!string.IsNullOrWhiteSpace(commend.Username))
                    query = query.Where(x => x.Username == commend.Username).ToList();
                if (!string.IsNullOrWhiteSpace(commend.Email))
                    query = query.Where(x => x.Email == commend.Email).ToList();
                if (!string.IsNullOrWhiteSpace(commend.FullName))
                    query = query.Where(x => x.FullName == commend.FullName).ToList();
                if (!string.IsNullOrWhiteSpace(commend.Number))
                    query = query.Where(x => x.Number == commend.Number).ToList();
            }
            return query;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Exist(string Username, string Email, string Number)
        {
            var account = _context.accounts
                .Any(x => x.Username == Username || x.Email == Email || x.Number == Number);
            if (account == true) return true;
            return false;
        }

        public AccountModel GetByUsername(string Username)
        {
            return _context.accounts.SingleOrDefault(x => x.Username == Username);
        }
    }
}
