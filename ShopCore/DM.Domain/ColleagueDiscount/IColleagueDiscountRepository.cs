using DM.Application.Contract.ColloeagueDiscount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Domain.ColleagueDiscount
{
    public interface IColleagueDiscountRepository
    {
        void Create(ColleagueDiscountModel commend);
        ColleagueDiscountModel GetBy(long Id);
        List<ColleagueDiscountViewModel> GetAllBy(SearchColleagueDiscount commend);
        void Save();


    }
}
