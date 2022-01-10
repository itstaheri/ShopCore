using AM.Application.Contract.Role;
using AM.Domain.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application
{
    public class RoleApplication : IRoleApplication
    {
        private readonly IRoleRepository _repository;

        public RoleApplication(IRoleRepository repository)
        {
            _repository = repository;
        }

        public void Create(CreateRole commend)
        {
            var role = new RoleModel(commend.Name);
            _repository.Create(role);
        }

        public void Edit(EditRole commend)
        {
            var role = _repository.GetBy(commend.Id);
            role.Edit(commend.Name);
            _repository.Save();
        }

        public List<RoleViewModel> List()
        {
            return _repository.GetAll();
        }

        public EditRole ValueForEdit(long Id)
        {
            var role = _repository.GetBy(Id);
            return new EditRole
            {
                Id = role.Id,
                Name = role.Name,
            };
        }
    }
}
