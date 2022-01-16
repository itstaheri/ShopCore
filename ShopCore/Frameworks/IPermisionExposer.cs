using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks
{
    public interface IPermisionExposer
    {
        Dictionary<string,List<PermisionDto>> Expose();
    }
}
