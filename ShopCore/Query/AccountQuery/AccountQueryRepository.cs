using AM.Application.Contract.Account;
using AM.Domain.AccountAgg;
using AM.Infrastracture.Efcore;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using Query.Contract.Account;
using SM.Domain.OrderAgg;
using SM.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.AccountQuery
{
    public class AccountQueryRepository : IAccountQueryRepository
    {
        private readonly AccountContext _context;
        private readonly ShopContext _shop;
      

        public AccountQueryRepository(AccountContext context, ShopContext shop)
        {
            _context = context;
            _shop = shop;
        }

        public void EditAddress(AddressQueryViewModel commend)
        {
            var info = _context.accounts.SingleOrDefault(x => x.Id == commend.Id);
            info.accountAddress.Add(commend.PostalCode, commend.City, commend.County,commend.Address, commend.UserId);
            _context.SaveChanges();
        }

       

        public AccountQueryViewModel GetProfileItems(long UserId)
        {

            var query = _context.accounts.Select(x => new AccountQueryViewModel
            {

                Id = x.Id,
                Address = mappingAddress(x.accountAddress),
                Email = x.Email,
                Number = x.Number,
                Username = x.Username,
                
                

            }).AsNoTracking().SingleOrDefault(x => x.Id == UserId);

            query.Orders = _shop.orders.Where(x => x.UserId == query.Id).Select(x => new OrderQueryViewModel
            {
                Id = x.Id,
                Date = x.OrderDate.ToFarsi(),
                Status = x.Status,
                PayAmount = x.PayAmount,
                PayMethod = x.PaymentMethod,
                orderDetails = mappingOrderdetail(x.orderDetails),
                Code =x.Code
            }).AsNoTracking().ToList();

            return query;

        }

        private static List<OrderDetailQueryViewModel> mappingOrderdetail(List<OrderDetailModel> orderDetails)
        {

            return orderDetails.Select(x => new OrderDetailQueryViewModel
            {
                Id =x.Id,
                Count =x.Count,
                TotalPrice =x.TotalPrice,
                ProductId = x.ProductId
            }).ToList();
        }

        private static AddressQueryViewModel mappingAddress(AccountAddressModel accountAddress)
        {
            if (accountAddress == null)
                return new AddressQueryViewModel();


            return new AddressQueryViewModel
            {
                Id = accountAddress.Id,
                Address = accountAddress.Address,
                City = accountAddress.City,
                County = accountAddress.County,
                PostalCode = accountAddress.PostalCode

            };
        }

        public AddressQueryViewModel GetValueForEditAddress(long Id)
        {
            if (_context.accounts.SingleOrDefault(x => x.Id == Id).accountAddress == null)
                return new AddressQueryViewModel();
            
            var info = _context.accounts.SingleOrDefault(x => x.Id == Id).accountAddress;
            return new AddressQueryViewModel
            {
                Id = info.Id,
                Address = info.Address,
                City = info.City,
                County = info.County,
                PostalCode = info.PostalCode,
                UserId = info.UserId
            };
        }

     

      
    }
}
