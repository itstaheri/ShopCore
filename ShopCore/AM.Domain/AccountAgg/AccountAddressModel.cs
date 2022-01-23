using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.AccountAgg
{
    public class AccountAddressModel
    {
        public void Add(long postalCode, string city, string county, string address, long userId)
        {
            PostalCode = postalCode;
            City = city;
            County = county;
            Address = address;
            UserId = userId;
        }

        public long Id { get; private set; }
        public long PostalCode { get; private set; }
        public string City { get; private set; }
        public string County { get; private set; }
        public string Address { get; private set; }
        public long UserId { get; set; }
        public AccountModel account { get; private set; }
    }
}
