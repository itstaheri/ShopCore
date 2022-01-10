using _0_Framework.Application;
using AM.Application.Contract.Account;
using AM.Domain.AccountAgg;
using Frameworks;
using System;
using System.Collections.Generic;

namespace AM.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IFileUploader _Uploader;
        private readonly IPasswordHasher _ToHash;
        private readonly IAccountRepository _repository;
        public AccountApplication(IAccountRepository repository, IPasswordHasher ToHash, IFileUploader Uploader)
        {
            _repository = repository;
            _ToHash = ToHash;
            _Uploader = Uploader;
        }
        public void Active(long Id)
        {
            var account = _repository.GetBy(Id);
            account.Actived();
            _repository.Save();
        }

        public void ChangePassword(ChangePasswordModel commend)
        {
            var account = _repository.GetBy(commend.Id);
            if (commend.Password == commend.RePassword)
            {
                var Password = _ToHash.Hash(commend.Password);
                account.ChangePassword(Password);
                _repository.Save();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void Create(CreateAccount commend)
        {
            string path = $"{commend.Username}";
            var PicName = _Uploader.Upload(commend.Picture, "ProfileImages", path);


            if (_repository.Exist(commend.Username, commend.Email, commend.Number) != true)
            {
                string Password = _ToHash.Hash(commend.Password);
                var account = new AccountModel(commend.FullName, commend.Username, Password, commend.RoleId, commend.Number, PicName, commend.Email);
                _repository.Create(account);
            }
        }

        public void Edit(EditAccount commend)
        {
            string path = $"{commend.Username}";
            var PicName = _Uploader.Upload(commend.Picture, "ProfileImages", path);

            if (_repository.Exist(commend.Username, commend.Email, commend.Number) != true)
            {
                var account = _repository.GetBy(commend.Id);
                account.Edit(commend.FullName, commend.Username, commend.RoleId, commend.Number, PicName, commend.Email);
                _repository.Save();
            }


        }

        public EditAccount GetValueForEdit(long Id)
        {
            var account = _repository.GetBy(Id);
            return new EditAccount
            {
                Id = account.Id,
                Email = account.Email,
                FullName = account.FullName,
                Number = account.Number,
                ProfilePicture = account.ProfilePicture,
                RoleId = account.RoleId,
                Username = account.Username
            };
        }

        public List<AccountViewModel> List(AccountSearchModel commend)
        {
            return _repository.GetAll(commend);
        }

        public void Removed(long Id)
        {
            var account = _repository.GetBy(Id);
            account.Removed();
            _repository.Save();
        }


    }
}
