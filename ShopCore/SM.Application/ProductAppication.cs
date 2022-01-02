﻿using Frameworks;
using SM.Application.Contracts.Product;
using SM.Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application
{
    public class ProductAppication : IProductApplication
    {
        private readonly IProductRepository _repository;
        private readonly IFileUploader _Uploader;
        public ProductAppication(IProductRepository repository, IFileUploader uploader)
        {
            _repository = repository;
            _Uploader = uploader;
        }

        public void Active(long id)
        {
            var product = _repository.GetBy(id);
            product.Actived();
            _repository.Save();

        }

        public void Create(CreateProduct commend)
        {
            var path = $"{commend.ProductName}";
            var picture = _Uploader.Upload(commend.OriginalImage,path);
            var Product = new ProductModel(commend.ProductName, commend.ProductCode, picture, commend.Description
                , commend.ShortDescription, commend.QuantityInStock, commend.PictureAlt
                , commend.PictureTitle, commend.Slug, commend.Keywoard, commend.MetaDescription, commend.CategoryId
                , commend.Storage, commend.ScreenSize, commend.NetworkSupport, commend.OperatingSystem, commend.Resolution, commend.Ram, commend.TouchId);

            _repository.Create(Product);
        }

        public void Edit(EditProduct commend)
        {
            var path = $"{commend.ProductName}";
            var picture = _Uploader.Upload(commend.OriginalImage,path);
            var GetProduct = _repository.GetBy(commend.Id);
            GetProduct.Edit(commend.ProductName, commend.ProductCode, picture, commend.Description
                , commend.ShortDescription, commend.QuantityInStock, commend.PictureAlt
                , commend.PictureTitle, commend.Slug, commend.Keywoard, commend.MetaDescription, commend.CategoryId
                , commend.Storage, commend.ScreenSize, commend.NetworkSupport, commend.OperatingSystem, commend.Resolution, commend.Ram, commend.TouchId);
            _repository.Save();
        }

        public List<ProductViewModel> GetAll(SearchProduct commend)
        {
            return _repository.GetProductsBy(commend);
        }

        public EditProduct GetValueForEdit(long Id)
        {
            var value = _repository.GetBy(Id);
            return new EditProduct
            {
                Id = value.Id,
                ProductName = value.ProductName,
                Picture = value.Picture,
                Description = value.Description,
                MetaDescription = value.MetaDescription,
                ShortDescription = value.ShortDescription,
                CategoryId = value.CategoryId,
                Keywoard = value.Keywoard,
                PictureAlt = value.PictureAlt,
                PictureTitle = value.PictureTitle,
                Slug = value.PictureTitle,
                ProductCode = value.ProductCode,
                QuantityInStock = value.QuantityInStock
            };
        }

        public void Remove(long id)
        {
            var product = _repository.GetBy(id);
            product.Deleted();
            _repository.Save();
        }
    }
}
