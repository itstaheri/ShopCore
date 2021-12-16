using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Application.Contract.CustomerDiscount
{
    public interface ICustomerDiscountApplication
    {
        void Create(CreateCustomerDiscount commend);
        void Edit(EditCustomerDiscount commend);
        EditCustomerDiscount GetValueForEdit(long id);
        List<CustomerDiscountViewmodel> GetAll();
        
    }
}
