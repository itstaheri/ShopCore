using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks
{
    public class NeedsPermissionAttribute : Attribute
    {
        public NeedsPermissionAttribute(int permission)
        {
            Permission = permission;
        }

        public int Permission { get; set; }
    }
}
