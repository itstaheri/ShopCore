using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Application.Contract.ColloeagueDiscount
{
    public interface IColleagueDiscountApplication
    {
        void Create(CreateColleagueDiscount commend);
        void Edit(EditColleagueDiscount commend);
        EditColleagueDiscount GetValueForEdit(long Id);
        List<ColleagueDiscountViewModel> GetAll(SearchColleagueDiscount commend);
        void IsRemoved(long Id);
        void IsRestore(long Id);
    }
}
