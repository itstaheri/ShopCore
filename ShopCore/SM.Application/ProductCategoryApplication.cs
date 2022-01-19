using Frameworks;
using SM.Application.Contracts.ProductCategory;
using SM.Domain.ProductCategory;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SM.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IFileUploader _Uploader;
        private readonly IProductCategoryRepository _repository;

        public ProductCategoryApplication(IProductCategoryRepository repository, IFileUploader Uploader)
        {
            _repository = repository;
            _Uploader = Uploader;
        }

        public void Active(long id)
        {
            var ProductCategory = _repository.Get(id);
            ProductCategory.Active();
            _repository.Save();
        }

        public void Create(CreateProductCategory commend)
        {
            if (_repository.ExistByName(commend.CategoryName))
            {

            }
            else
            {
                var path = $"{commend.CategoryName}";
                var picture = _Uploader.Upload(commend.CategoryPicture, "CategoryImages", path);
                var ProductCategory = new ProductCategoryModel(commend.CategoryName, commend.Slug, picture);
                _repository.Create(ProductCategory);
            }
        }

        public void Delete(long id)
        {
            var ProductCategory = _repository.Get(id);
            ProductCategory.Deleted();
            _repository.Save();
        }

        public void Edit(EditProductCategory commend)
        {
            var path = $"{commend.CategoryName}";
            var picture = _Uploader.Upload(commend.CategoryPicture, "CategoryImages", path);
            var productcategory = _repository.Get(commend.Id);
            productcategory.Edit(commend.CategoryName, commend.Slug, picture);
            _repository.Save();
        }

   

        public ProductCategoryViewModel GetBy(long id)
        {
            var Pcategory = _repository.Get(id);
            return new ProductCategoryViewModel
            {
                id = Pcategory.Id,
                CreationDate = Pcategory.CreationDate.ToString(),
                CategoryName = Pcategory.CategoryName
            };
        }

        public EditProductCategory GetIdForEdit(long id)
        {
            var value = _repository.Get(id);
            if (_repository.ExistByName(value.CategoryName))
            {
                return new EditProductCategory
                {
                    Id = value.Id,
                    CategoryName = value.CategoryName,
                    Slug = value.Slug
                };
            }
            return null;
        }

        public List<ProductCategoryViewModel> SearchByNames(SearchProductCategoryByName commend)
        {
            return _repository.SearchByNames(commend);
        }
    }
}
