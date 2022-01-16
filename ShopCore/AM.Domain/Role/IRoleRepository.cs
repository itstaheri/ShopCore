using AM.Application.Contract.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.Role
{
    public interface IRoleRepository
    {
        void Create(RoleModel commend);
        EditRole Edit(long Id);
        RoleModel GetBy(long Id);
        List<RoleViewModel> GetAll();
        void Save();
    }
}
