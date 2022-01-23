using AM.Domain.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.AccountAgg
{
    public class AccountModel
    {
        protected AccountModel()
        {

        }
        public AccountModel(string fullName, string username, string password, long roleId, string number, string profilePicture, string email)
        {
            FullName = fullName;
            Username = username;
            Password = password;
            RoleId = roleId;
            Number = number;
            if (!string.IsNullOrWhiteSpace(profilePicture))
                ProfilePicture = profilePicture;
            Email = email;
            IsRemoved = false;
            SignupDate = DateTime.Now;
            accountAddress = new AccountAddressModel();
        }
        public void Edit(string fullName, string username, long roleId, string number, string profilePicture, string email)
        {
            FullName = fullName;
            Username = username;
            RoleId = roleId;
            Number = number;
            if (!string.IsNullOrWhiteSpace(profilePicture))
                ProfilePicture = profilePicture;
            Email = email;
            accountAddress = new AccountAddressModel();
        }

        public void Actived() => IsRemoved = false;
        public void Removed() => IsRemoved = true;
        public void ChangePassword(string password) => Password = password;

        public long Id { get;private set; }
        public string FullName { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public long RoleId { get; private set; }
        public RoleModel role { get; private set; }
        public string Number { get; private set; }
        public string ProfilePicture { get; private set; }
        public string Email { get; private set; }
        public bool IsRemoved { get; private set; }
        public DateTime SignupDate { get; private set; }
        public AccountAddressModel accountAddress { get; private set; }
    }
}
