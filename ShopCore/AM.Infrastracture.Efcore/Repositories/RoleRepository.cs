using AM.Application.Contract.Role;
using AM.Domain.Role;
using Frameworks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastracture.Efcore.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AccountContext _context;

        public RoleRepository(AccountContext context)
        {
            _context = context;
        }

        public void Create(RoleModel commend)
        {
            _context.roles.Add(commend);
            _context.SaveChanges();
        }

        public List<RoleViewModel> GetAll()
        {
            return _context.roles.Select(x => new RoleViewModel
            {
                Id = x.Id,
                CreationDate = x.CreationDate.ToFarsi(),
                Name = x.Name,
                
            }).ToList();
        }

        public EditRole Edit(long Id)
        {
            return _context.roles.Select(x => new EditRole
            {
                Id = x.Id,
                Name = x.Name,
                Mappedpermisions = Mappermisions(x.Permissions)
            }).AsNoTracking().FirstOrDefault(x=>x.Id == Id);
           
        }

        private static List<PermisionDto> Mappermisions(IEnumerable<Permission> permissions)
        {
            return permissions.Select(x => new PermisionDto(x.Code, x.Name)).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public RoleModel GetBy(long Id)
        {
            return _context.roles.SingleOrDefault(x => x.Id == Id);
        }
    }
}
