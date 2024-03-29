﻿using SM.Domain.OrderAgg;
using SM.Domain.ProductCategory;
using SM.Domain.ProductComment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.Product
{
    public class ProductModel
    {
        public ProductModel(string productName, string productCode,string picture, string description, string shortDescription, 
            long quantityInStock,string pictureAlt, string pictureTitle, string slug, 
            string keywoard, string metaDescription, long categoryId,string storage,string screensize,string networkSupport
            ,string operatingSystem,string resolution,string ram,string touchID)
        {
            ProductName = productName;
            ProductCode = productCode;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            Description = description;
            ShortDescription = shortDescription;
            QuantityInStock = quantityInStock;
            IsDeleted = false;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug; 
            Keywoard = keywoard;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
            CreationDate = DateTime.Now;
            Storage = storage;
            ScreenSize = screensize;
            NetworkSupport = networkSupport;
            OperatingSystem = operatingSystem;
            Resolution = resolution;
            Ram = ram;
            TouchId = touchID;

        }
        public void Edit(string productName, string productCode,string picture, string description, string shortDescription,
          long quantityInStock, string pictureAlt, string pictureTitle, string slug,
          string keywoard, string metaDescription, long categoryId, string storage, string screensize, string networkSupport
            , string operatingSystem, string resolution, string ram, string touchID)
        {
            ProductName = productName;
            ProductCode = productCode;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;            
            Description = description;
            ShortDescription = shortDescription;
            QuantityInStock = quantityInStock;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywoard = keywoard;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
            Storage = storage;
            ScreenSize = screensize;
            NetworkSupport = networkSupport;
            OperatingSystem = operatingSystem;
            Resolution = resolution;
            Ram = ram;
            TouchId = touchID;
        }
        protected ProductModel()
        {

        }

        //public void InStock() => IsInStock = true;
        //public void NotInStock() => IsInStock = false;

        public void Actived() => IsDeleted = false;
        public void Deleted() => IsDeleted = true;
       
       
        public long ProductId { get;private set; }
        public string ProductName { get; private set; }
        public string ProductCode { get; private set; }
        public string Picture { get; private set; }
        public string Description { get; private set; }
        public string ShortDescription { get; private set; }
        public long QuantityInStock { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }

        public string Storage { get; private set; }
        public string ScreenSize { get; private set; }
        public string NetworkSupport { get; private set; }
        public string OperatingSystem { get; private set; }
        public string Resolution { get;private set; }
        public string Ram { get; private set; }
        public string TouchId { get; private set; }


        //SEO Fields
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Keywoard { get; private set; }
        public string MetaDescription { get; private set; }
        //

        public long CategoryId { get; private set; }
        public ProductCategoryModel productcategory { get; private set; }

        public List<ProductCommentModel> Comments { get;private set; }
       // public OrderDetailModel orderDetail { get; private set; }

    }
}
