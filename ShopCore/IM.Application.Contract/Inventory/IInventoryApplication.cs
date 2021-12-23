using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Application.Contract.Inventory
{
    public interface IInventoryApplication
    {
        void Create(CreateInventory commend);
        void Edit(EditInventory commend);
        EditInventory GetValueForEdit(long Id);
        List<InventoryViewModel> GetAll(SearchInventory commend);
        void Increase(IncreaseInventory commend);
        void Reduce(ReduceInventory commend);
        void ReduceList(List<ReduceInventory> commend);
    }
}
