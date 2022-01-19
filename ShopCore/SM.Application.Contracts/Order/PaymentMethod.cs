using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Contracts.Order
{
    public  class PaymentMethod
    {
        public PaymentMethod(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static List<PaymentMethod> GetMethod()
        {
            return new List<PaymentMethod>
            {
                new PaymentMethod(2,"پرداخت نقدی","در این روش شما سفارش خود را ثبت کرده و مبلغ را درب منزل پرداخت خواهید کرد"),
                new PaymentMethod(1,"پرداخت اینترنتی","در این روش شما به درگاه پرداخت هدایت میشوید و سفارش خود را انلاین پرداخت خواهید کرد")
            };
            
        }
        public PaymentMethod GetBy(long id)
        {
            return GetMethod().FirstOrDefault(x => x.Id == id);
        }
    }
}
