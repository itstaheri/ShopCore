﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Productcategory
{
    public interface IProductcategoryQuery
    {

        List<ProductCategoryQueyViewModel> GetAll();
        List<ProductCategoryQueyViewModel> GetCategoriesWithProduct(long CategoryId);
    }
}
