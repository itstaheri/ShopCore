using AM.Domain.AccountAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.Role
{
    public class RoleModel
    {
        protected RoleModel() { }
        public RoleModel(string name)
        {
            Name = name;
            CreationDate = DateTime.Now;
            accounts = new List<AccountModel>();
        }
        public void Edit(string name)
        {
            Name = name;
            CreationDate = DateTime.Now;


        }
        public long Id { get;private set; }
        public string Name { get;private set; }
        public DateTime CreationDate { get; private set; }
        public List<AccountModel> accounts { get; private set; }
    }
}
