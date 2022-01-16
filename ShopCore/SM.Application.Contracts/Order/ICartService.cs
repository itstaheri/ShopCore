using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Order
{
   public  interface ICartService
    {
        void Set(Cart cart);
        Cart Get();
    }
}
