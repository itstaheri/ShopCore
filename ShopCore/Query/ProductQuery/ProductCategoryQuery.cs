using DM.infrastructure.Efcore;
using Frameworks;
using IM.Infrastracture.Efcore;
using Microsoft.EntityFrameworkCore;
using Query.Contract.Product;
using Query.Contract.Productcategory;
using SM.Domain.Product;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.ProductQuery
{
    public class ProductCategoryQuery : IProductcategoryQuery
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventory;
        private readonly DiscountContext _discount;

        public ProductCategoryQuery(ShopContext context, InventoryContext inventory, DiscountContext discount)
        {
            _context = context;
            _inventory = inventory;
            _discount = discount;
        }

        public List<ProductCategoryQueyViewModel> GetAll()
        {
            return _context.productcategories.Where(x => x.IsDeleted == false)
                .Select(x => new ProductCategoryQueyViewModel { CategoryName = x.CategoryName, Slug = x.Slug, Id = x.Id })
                .ToList();
            
        }

        public List<ProductCategoryQueyViewModel> GetCategoriesWithProduct(long CategoryId)
        {
            var inventory = _inventory.inventory.Select(x => new { x.Productid, x.Price });

            var discount = _discount.customerDiscounts
              .Select(x => new { x.DiscountRate,x.ProductId}).ToList();

            var category = _context.productcategories.Where(x=>x.IsDeleted == false).Include(x => x.products).ThenInclude(x=>x.productcategory).Select(x => new ProductCategoryQueyViewModel
            {
                Id = x.Id,
                CategoryName = x.CategoryName,
                Slug = x.Slug,
                products = Mapproducts(x.products)

            }).AsNoTracking().ToList();

            
            foreach (var categories in category)
            {
                foreach (var products in categories.products)
                {
                    var Inventoryproduct = inventory.FirstOrDefault(x => x.Productid == products.Id);
                    if (Inventoryproduct != null)
                    {
                        products.Price = Inventoryproduct.Price.ToMoney();
                        var discountproduct = discount.FirstOrDefault(x => x.ProductId == products.Id);
                        if (discountproduct!=null)
                        {
                            var discountrate = discountproduct.DiscountRate;
                            products.DiscountRate = discountrate;
                            products.HasDiscount = discountrate > 0;
                            
                            var discountValue = Math.Round((Inventoryproduct.Price * discountrate) / 100);
                            products.PriceAfterDiscount = (Inventoryproduct.Price - discountValue).ToMoney();

                        }

                    }
                  
                 

                }
            }
            if (CategoryId > 0)
            {
                category = category.Where(x => x.Id == CategoryId).ToList();
            }
            return category;
        }

        private static List<ProductQueryModel> Mapproducts(List<ProductModel> products)
        {
            return products.Where(x => x.IsDeleted == false).Select(x => new ProductQueryModel
            {
                Id = x.ProductId,
                ProductCode = x.ProductCode,
                CategoryName = x.productcategory.CategoryName,
                ProductName = x.ProductName,
                PictureAlt = x.PictureAlt,
                Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug,
                
            }).ToList();
            
        }
    }
}
