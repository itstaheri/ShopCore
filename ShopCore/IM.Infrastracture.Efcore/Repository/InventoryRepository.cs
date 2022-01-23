using Frameworks;
using IM.Application.Contract.Inventory;
using IM.Domain.Inventory;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Infrastracture.Efcore.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryContext _context;
        private readonly ShopContext _product;

        public InventoryRepository(InventoryContext context, ShopContext product)
        {
            _context = context;
            _product = product;
        }

        public void Create(InventoryModel commend)
        {
            var check = _context.inventory.Any(x => x.Productid == commend.Productid);
            if (check !=true)
            {
                _context.inventory.Add(commend);
                _context.SaveChanges();
            }
            
           
        }

        public InventoryModel GetBy(long ProductId)
        {
           return _context.inventory.SingleOrDefault(x => x.Productid == ProductId);
        }

        public InventoryModel GetDetails(long Id)
        {
            return  _context.inventory.SingleOrDefault(x => x.Id == Id);
          
        }

        public List<InventoryOperationViewModel> GetForLoggs(long InventoryId)
        {
            var inventory = _context.inventory.FirstOrDefault(x => x.Id == InventoryId);
            return inventory.inventoryOperations.Select(x => new InventoryOperationViewModel
            {
                Id = x.Id,
                Description = x.Description,
                OperationDate = x.OperationDate.ToFarsi(),
                Count = x.Count,
                CurrentCount = x.CurrentCount,
                Operation = x.Operation,
                OperatorId = x.OperatorId,
                OrderId = x.OrderId,
                OperatorName = "Admin",
                
                
            }).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<InventoryViewModel> search(SearchInventory commend)
        {
            var product = _product.products.Select(x => new { x.ProductId, x.ProductName });
            var query = _context.inventory.Select(x => new InventoryViewModel
            {
                Id = x.Id,
                InStock = x.InStock,
                Price = x.Price,
                ProductId = x.Productid,
                CurrentCount = x.CurrentInventory(),
                
            });
            if (commend.ProductId>0)
                query = query.Where(x => x.ProductId == commend.ProductId);
            if (commend.InStock ==false)
                query = query.Where(x => x.InStock);

            var inventory = query.OrderByDescending(x => x.Id).ToList();
            inventory.ForEach(item =>
            {
                item.ProductName = product.FirstOrDefault(x => x.ProductId == item.ProductId)?.ProductName;

            });
            return inventory;


        }
    }
}
