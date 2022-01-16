using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Permisions
{
    public static class InventoryPermission
    {
        //Inventory
        public const int ListInventory = 30;
        public const int SearchInventory = 31;
        public const int CreateInventory = 32;
        public const int EditInventory = 33;
        public const int IncreaseInventory = 34;
        public const int ReduceInventory = 35;
        public const int HistoryInventory = 36;
    }
}
