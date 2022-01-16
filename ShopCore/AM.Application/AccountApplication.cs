﻿using AM.Application.Contract.Account;
using AM.Domain.AccountAgg;
using Frameworks;
using System;
using System.Collections.Generic;
using Framework;
using AM.Domain.Role;
using System.Linq;
using AM.Application.Contract.Role;

namespace AM.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IFileUploader _Uploader;
        private readonly IPasswordHasher _ToHash;
        private readonly IAccountRepository _repository;
        private readonly IAuthHelper _AuthHelper;
        private readonly IRoleApplication _roleRepository;
        public AccountApplication(IAccountRepository repository, IPasswordHasher ToHash, IFileUploader Uploader, IAuthHelper AuthHelper, IRoleApplication roleRepository)
        {
            _repository = repository;
            _ToHash = ToHash;
            _Uploader = Uploader;
            _AuthHelper = AuthHelper;
            _roleRepository = roleRepository;
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

        public OperationResult Register(Register commend)
        {
            var operation = new OperationResult();
            string path = $"{commend.Username}";
            var PicName = _Uploader.Upload(commend.Picture, "ProfileImages", path);


            if (_repository.Exist(commend.Username, commend.Email, commend.Number) != true)
            {
                if (commend.RoleId == 0) commend.RoleId = 2;

                string Password = _ToHash.Hash(commend.Password);
                var account = new AccountModel(commend.FullName, commend.Username, Password, commend.RoleId, commend.Number, PicName, commend.Email);
                _repository.Create(account);
                return operation.succeeded();
            }
            return operation.Failed(message: "ثبت نام ناموفق");
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

        public OperationResult Login(Login commend)
        {
            var operation = new OperationResult();
            var account = _repository.GetByUsername(commend.Username);
            if (account == null)
                return operation.Failed(ApplicationMessages.WrongUserPass);

            (bool Verified, bool NeedsUpgrade) Result = _ToHash.Check(account.Password, commend.Password);

            if (Result.Verified != true)
                return operation.Failed(ApplicationMessages.WrongUserPass);

            var permission = _roleRepository.ValueForEdit(account.RoleId).Mappedpermisions.Select(x=>x.Code).ToList();


            var AuthViewModel = new AuthViewModel
            {
                Id = account.Id,
                FullName = account.FullName,
                Number = account.Number,
                RoleId = account.RoleId,
                Username = account.Username,
                Email = account.Email,
                Picture = account.ProfilePicture,
                Permissions = permission


            };
            _AuthHelper.Signin(AuthViewModel);
            return operation.succeeded();

        }

        public void Logout()
        {
            _AuthHelper.SignOut();
        }

        public void Removed(long Id)
        {
            var account = _repository.GetBy(Id);
            account.Removed();
            _repository.Save();
        }


    }
}
