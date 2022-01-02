using DM.infrastructure.Efcore;
using Frameworks;
using IM.Infrastracture.Efcore;
using Microsoft.EntityFrameworkCore;
using Query.Contract.Product;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.ProductQuery
{
    public class ProductQueryRepository : IProductQueryRepository
    {
        private readonly ShopContext _shop;
        private readonly DiscountContext _discount;
        private readonly InventoryContext _inventory;

        public ProductQueryRepository(ShopContext shop, DiscountContext discount, InventoryContext inventory)
        {
            _shop = shop;
            _discount = discount;
            _inventory = inventory;
        }

        public List<ProductQueryModel> list()
        {
            var inventory = _inventory.inventory.Select(x => new { x.Productid, x.Price }).ToList();
            var discount = _discount.customerDiscounts.Select(x => new { x.DiscountRate, x.ProductId }).ToList();

            var query = _shop.products.Where(x => x.IsDeleted == false).Select(x => new ProductQueryModel
            {
                Id = x.Id,
                CategoryName = x.productcategory.CategoryName,
                Slug = x.Slug,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ProductName = x.ProductName,
                ProductCode = x.ProductCode,


            }).AsNoTracking().ToList();
            foreach (var products in query)
            {
                var Inventoryproduct = inventory.FirstOrDefault(x => x.Productid == products.Id);
                if (Inventoryproduct != null)
                {
                    products.Price = Inventoryproduct.Price.ToMoney();
                    var discountproduct = discount.FirstOrDefault(x => x.ProductId == products.Id);
                    if (discountproduct != null)
                    {
                        var discountrate = discountproduct.DiscountRate;
                        products.DiscountRate = discountrate;
                        products.HasDiscount = discountrate > 0;

                        var discountValue = Math.Round((Inventoryproduct.Price * discountrate) / 100);
                        products.PriceAfterDiscount = (Inventoryproduct.Price - discountValue).ToMoney();

                    }

                }

            }

            return query;
        }

        public List<ProductQueryModel> Search(string commend)
        {
            var inventory = _inventory.inventory.Select(x => new { x.Productid, x.Price });

            var discount = _discount.customerDiscounts
              .Select(x => new { x.DiscountRate, x.ProductId }).ToList();

            var query = _shop.products.Select(x => new ProductQueryModel
            {
                Id = x.Id,
                CategoryName = x.productcategory.CategoryName,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                ProductName = x.ProductName,
                ProductCode = x.ProductCode,
                CategoryId = x.CategoryId,
                ShortDescription = x.ShortDescription


            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(commend))
                query = query.Where(x => x.ProductName
                .Contains(commend) || x.ShortDescription.Contains(commend));

            var product = query.OrderByDescending(x => x.Id).ToList();

            foreach (var products in product)
            {
                var Inventoryproduct = inventory.FirstOrDefault(x => x.Productid == products.Id);
                if (Inventoryproduct != null)
                {
                    products.Price = Inventoryproduct.Price.ToMoney();
                    var discountproduct = discount.FirstOrDefault(x => x.ProductId == products.Id);
                    if (discountproduct != null)
                    {
                        var discountrate = discountproduct.DiscountRate;
                        products.DiscountRate = discountrate;
                        products.HasDiscount = discountrate > 0;

                        var discountValue = Math.Round((Inventoryproduct.Price * discountrate) / 100);
                        products.PriceAfterDiscount = (Inventoryproduct.Price - discountValue).ToMoney();

                    }

                }

            }
            return product;
        }
    }
}
