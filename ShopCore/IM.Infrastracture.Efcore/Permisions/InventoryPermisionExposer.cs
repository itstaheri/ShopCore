using Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Infrastracture.Efcore.Permisions
{
    public class InventoryPermisionExposer : IPermisionExposer
    {
        public Dictionary<string, List<PermisionDto>> Expose()
        {
            return new Dictionary<string, List<PermisionDto>>
           {
               {
                   "Inventory",new List<PermisionDto>
                   {
                       new PermisionDto(30,"ListInventory"),
                       new PermisionDto(31,"SearchInventory"),
                       new PermisionDto(32,"CreateInventory"),
                       new PermisionDto(33,"EditInventory"),
                       new PermisionDto(34,"IncreaseInventory"),
                       new PermisionDto(35,"ReduceInventory"),
                       new PermisionDto(36,"HistoryInventory"),
                   }
               }
               

           };
        }
    }
}
