using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Domain.Inventory
{
    public class InventoryModel
    {
        protected InventoryModel()
        {

        }
        public InventoryModel(long productid, double price)
        {
            Productid = productid;
            Price = price;
            InStock = true;
        }
        public void Edit(long productid, double price,bool inStock)
        {
            Productid = productid;
            Price = price;
            InStock = InStock;
        }
        //mohasebe tedad mojood
        public long CurrentInventory()
        {
            var sum = inventoryOperations.Where(x => x.Operation).Sum(x => x.Count);
            var min = inventoryOperations.Where(x => !x.Operation).Sum(x => x.Count);
            return  sum - min;
        }
        public void Increase(long count,long operatorId,string description)
        {
            var currentcount = CurrentInventory() + count;
            var operation = new InventoryOperationModel(true, count, operatorId, currentcount, description, 0, Id);
            inventoryOperations.Add(operation);
            InStock = currentcount > 0;
        }
        public void Reduce(long count, long operatorId, string description,long orderId)
        {
            var currentcount = CurrentInventory() - count;
            var operation = new InventoryOperationModel(true, count, operatorId, currentcount, description, orderId, Id);
            inventoryOperations.Add(operation);
            InStock = currentcount > 0;

        }
        public long Id { get;private set; }
        public long Productid { get; private set; }
        public double Price { get; private set; }
        public bool InStock { get; private set; }
        public List<InventoryOperationModel> inventoryOperations { get;private set; }
    }
}
