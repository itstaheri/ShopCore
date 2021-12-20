using DM.Application.Contract.ColloeagueDiscount;
using DM.Domain.ColleagueDiscount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Application
{
    public class ColleagueDiscountApplication : IColleagueDiscountApplication
    {
        private readonly IColleagueDiscountRepository _repository;

        public ColleagueDiscountApplication(IColleagueDiscountRepository repository)
        {
            _repository = repository;
        }

        public void Create(CreateColleagueDiscount commend)
        {
            var colleague = new ColleagueDiscountModel(commend.ProductId, commend.DiscountRate, commend.Username);
            _repository.Create(colleague);
        }

        public void Edit(EditColleagueDiscount commend)
        {
            var colleague = _repository.GetBy(commend.Id);
            colleague.Edit(commend.ProductId, commend.DiscountRate, commend.Username);
            _repository.Save();
        }

        public List<ColleagueDiscountViewModel> GetAll(SearchColleagueDiscount commend)
        {
            return _repository.GetAllBy(commend);
        }

        public EditColleagueDiscount GetValueForEdit(long Id)
        {
            var value = _repository.GetBy(Id);
            return new EditColleagueDiscount
            {
                DiscountRate = value.DiscountRate,
                Id = value.Id,
                ProductId = value.ProductId,
                Username = "",
               

            };
        }

        public void IsRemoved(long Id)
        {
            var colleague = _repository.GetBy(Id);
            colleague.Removed();
            _repository.Save();
        }

        public void IsRestore(long Id)
        {
            var colleague = _repository.GetBy(Id);
            colleague.Restore();
            _repository.Save();

        }
    }
}
