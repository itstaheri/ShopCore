﻿using DM.infrastructure.Efcore;
using Frameworks;
using IM.Infrastracture.Efcore;
using Microsoft.EntityFrameworkCore;
using Query.Contract.Product;
using SM.Application.Contracts.Order;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.IO;
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

        public List<CartItem> CheckInventory(List<CartItem> cartItems)
        {
            var inventory = _inventory.inventory.Include(x=>x.inventoryOperations)
                .Select(x=>new { x.InStock,x.Productid,x.inventoryOperations,x.Id}).AsNoTracking().ToList();
            if (cartItems==null || cartItems.Count <= 0)
                return null;

            foreach (var item in cartItems)
            {
                var itemInventory = inventory.Any(q => q.Productid == item.Id && q.inventoryOperations.FirstOrDefault(x=>x.InventoryId == q.Id).Count >= item.Count);
                if (itemInventory == true)
                    item.IsInStock = true;
               
            }
            return cartItems;
        }

        public List<string> GetCatalog(long id,string root)
        {
            var filename = _shop.products.SingleOrDefault(x => x.ProductId == id).ProductName;
            List<string> names = new List<string>();
            DirectoryInfo di = new DirectoryInfo($"{root}//Img//ProductImages//{filename}");
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo file in files)
            {
                names.Add(file.Name);
            }
            return names;
        }

        public ProductDetailQueryModel GetDetail(long id)
        {
           
            int discountRate = 0;
            double Price = 0;
            if (_inventory.inventory.FirstOrDefault(x => x.Productid == id)!=null)
            {
                 Price = _inventory.inventory.Select(x => new { x.Productid, x.Price }).FirstOrDefault(x => x.Productid == id).Price;

            }
            if (_discount.customerDiscounts.Any(x=>x.DiscountRate>0) == true)
            {
                 discountRate = _discount.customerDiscounts.Where(x => x.Start < DateTime.Now && x.End > DateTime.Now).Select(x => new { x.DiscountRate, x.ProductId }).FirstOrDefault(x => x.ProductId == id).DiscountRate;

            }
            var product = _shop.products.Include(x => x.productcategory).FirstOrDefault(x => x.ProductId == id);

            var query = new ProductDetailQueryModel
            {
                Id = product.ProductId,
                Description = product.Description,
                CreationDate = product.CreationDate.ToFarsi(),
                MetaDescription = product.MetaDescription,
                ShortDescription = product.ShortDescription,
                CategoryId = product.CategoryId,
                Keywoard = product.Keywoard,
                NetworkSupport = product.NetworkSupport,
                OperatingSystem = product.OperatingSystem,
                PictureAlt = product.PictureAlt,
                PictureTitle = product.PictureTitle,
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                Ram = product.Ram,
                Resolution = product.Resolution,
                Slug = product.Slug,
                ScreenSize = product.ScreenSize,
                TouchId = product.TouchId,
                Storage = product.Storage,
                Picture = product.Picture,
                CategoryName = product.productcategory.CategoryName,
                discountRate = discountRate

            };
            if (Price != null)
            {
                query.Price = Price.ToMoney();
                query.DoublePrice = Price;
                if (discountRate != null)
                {
                    var discountValue = Math.Round((Price * discountRate) / 100);
                    query.PriceAfterDiscount = (Price - discountValue).ToMoney();
                }
            }

            return query;
          
        }

        public List<ProductQueryModel> list()
        {
            var inventory = _inventory.inventory.Select(x => new { x.Productid, x.Price }).ToList();
            var discount = _discount.customerDiscounts.Where(x => x.Start < DateTime.Now && x.End > DateTime.Now).Select(x => new { x.DiscountRate, x.ProductId }).ToList();
            
            var query = _shop.products.Where(x => x.IsDeleted == false).Select(x => new ProductQueryModel
            {
                Id = x.ProductId,
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
                    products.DoublePrice = Inventoryproduct.Price;
                    var discountproduct = discount.FirstOrDefault(x => x.ProductId == products.Id);
                    if (discountproduct != null)
                    {
                        var discountrate = discountproduct.DiscountRate;
                        products.DiscountRate = discountrate;
                        if (discountrate > 0)
                            products.HasDiscount = true;


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
                Id = x.ProductId,
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
