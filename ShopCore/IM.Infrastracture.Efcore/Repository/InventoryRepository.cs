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
            _context.inventory.Add(commend);
            _context.SaveChanges();
        }

        public InventoryModel GetBy(long ProductId)
        {
            throw new NotImplementedException();
        }

        public InventoryModel GetDetails(long Id)
        {
            return  _context.inventory.SingleOrDefault(x => x.Id == Id);
            //return new EditInventory
            //{
            //    Id = value.Id,
            //    Price = value.Price,
            //    Productid = value.Productid
            //};
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<InventoryViewModel> search(SearchInventory commend)
        {
            var product = _product.products.Select(x => new { x.Id, x.ProductName });
            var query = _context.inventory.Select(x => new InventoryViewModel
            {
                Id = x.Id,
                InStock = x.InStock,
                Price = x.Price,
                ProductId = x.Productid,
                CurrentCount = x.CurrentInventory()
            });
            if (commend.ProductId>0)
                query = query.Where(x => x.ProductId == commend.ProductId);
            if (commend.InStock ==false)
                query = query.Where(x => !x.InStock);

            var inventory = query.OrderByDescending(x => x.Id).ToList();
            inventory.ForEach(item =>
            {
                item.ProductName = product.FirstOrDefault(x => x.Id == item.ProductId)?.ProductName;

            });
            return inventory;


        }
    }
}
