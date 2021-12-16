using DM.Application.Contract.CustomerDiscount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.CustomerDiscount
{
    public interface ICustomerDiscountRepository
    {
        void Create(CustomerDiscountModel commend);
        List<CustomerDiscountViewmodel> GetBy(SearchCustomerDiscount commend);
        CustomerDiscountModel GetById(long Id);
        void Save();
    }
}
