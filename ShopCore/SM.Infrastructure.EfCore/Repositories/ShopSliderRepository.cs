using SM.Application.Contracts.Slider;
using SM.Domain.Sliders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Infrastructure.EfCore.Repositories
{
    public class ShopSliderRepository : IShopSliderRepository
    {
        private readonly ShopContext _context;
        public ShopSliderRepository(ShopContext context)
        {
            _context = context;
        }
        public void Create(ShopSliderModel commend)
        {
            _context.shopSliders.Add(commend);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var Slider = _context.shopSliders.Where(x => x.Id==id).FirstOrDefault();
            _context.Remove(Slider);
            _context.SaveChanges();
        }

        public bool Exist(long id)
        {
            return _context.shopSliders.Any(x => x.Id == id);
        }

        public List<ShopSliderViewModel> GetAll()
        {
            return _context.shopSliders.Select(x=> new ShopSliderViewModel{
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture
                
            }).ToList();
        }

        public ShopSliderModel GetById(long Id)
        {
          
            return _context.shopSliders.SingleOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
