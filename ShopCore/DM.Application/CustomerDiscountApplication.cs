using DM.Application.Contract.CustomerDiscount;
using DM.Domain.CustomerDiscount;
using System;
using System.Collections.Generic;
using Frameworks;


namespace DM.Application
{
    public class CustomerDiscountApplication : ICustomerDiscountApplication
    {
        public string ProductName;
        private readonly Domain.CustomerDiscount.ICustomerDiscountRepository _repository;
        public CustomerDiscountApplication(ICustomerDiscountRepository repository)
        {
            _repository = repository;
        }

        public void Create(CreateCustomerDiscount commend)
        {
            var startdate = commend.Start.ToGeorgianDateTime();
            var endtdate = commend.End.ToGeorgianDateTime();
            var discount = new CustomerDiscountModel(commend.ProductId, commend.DiscountRate, startdate, endtdate, commend.reason);
            _repository.Create(discount);
        }

        public void Edit(EditCustomerDiscount commend)
        {
            var discount = _repository.GetById(commend.Id);
            discount.Edit(commend.ProductId, commend.DiscountRate, commend.Start.ToGeorgianDateTime(), commend.End.ToGeorgianDateTime(),commend.reason);
            _repository.Save();
        }
      
        public List<CustomerDiscountViewmodel> GetAll(SearchCustomerDiscount x)
        {
            return _repository.GetBy(x);
        }

        public EditCustomerDiscount GetValueForEdit(long id)
        {
            var discount = _repository.GetById(id);
            return new EditCustomerDiscount
            {
                Id = discount.Id,
                DiscountRate = discount.DiscountRate,
                Start = discount.Start.ToString(),
                End = discount.End.ToString(),
                ProductId = discount.ProductId,
                reason = discount.reason,

            };
        }
    }
}
