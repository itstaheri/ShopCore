using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Product
{
    public interface IProductApplication
    {
        void Create(CreateProduct commend);
        EditProduct GetValueForEdit(long Id);
        void Edit(EditProduct commend);
        List<ProductViewModel> GetAll(SearchProduct commend);
        void Active(long id);
        void Remove(long id);
    }
}
