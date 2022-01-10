using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Contract.Role
{
    public interface IRoleApplication
    {
        void Create(CreateRole commend);
        void Edit(EditRole commend);
        EditRole ValueForEdit(long Id);
        List<RoleViewModel> List();

    }
}
