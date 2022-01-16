using AM.Application.Contract.Role;
using AM.Domain.Role;
using Frameworks;
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
            var role = new RoleModel(commend.Name,new List<Permission>());
            _repository.Create(role);
        }

        public void Edit(EditRole commend)
        {
            var role = _repository.GetBy(commend.Id);

            var permission = new List<Permission>();
            commend.permisions.ForEach(code => permission.Add(new Permission(code)));
            role.Edit(commend.Name, permission);
            _repository.Save();
        }

        public List<RoleViewModel> List()
        {
            return _repository.GetAll();
        }

        public EditRole ValueForEdit(long Id)
        {
            return _repository.Edit(Id);
        }

     
    
    }
}
