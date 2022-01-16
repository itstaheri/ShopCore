using Frameworks;
using System.Collections.Generic;

namespace AM.Application.Contract.Role
{
    public class EditRole : CreateRole
    {
        public long Id { get; set; }
       public List<PermisionDto> Mappedpermisions { get; set; }
    }
}
