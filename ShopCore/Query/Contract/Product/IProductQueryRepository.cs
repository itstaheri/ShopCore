using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Contract.Product
{
    public interface IProductQueryRepository
    {
        List<ProductQueryModel> list();
        List<ProductQueryModel> Search(string commend);
    }
}
