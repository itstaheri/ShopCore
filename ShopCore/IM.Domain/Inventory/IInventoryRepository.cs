using IM.Application.Contract.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Domain.Inventory
{
    public interface IInventoryRepository
    {
        InventoryModel GetDetails(long Id);
        InventoryModel GetBy(long ProductId);
        List<InventoryViewModel> search(SearchInventory commend);
        void Create(InventoryModel commend);
        void Save();
    }
}
