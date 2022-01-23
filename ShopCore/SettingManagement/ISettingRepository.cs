using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingManagement
{
    public interface ISettingRepository
    {
        void Record(settingViewModel commend);
        void Edit(settingViewModel commend);
        settingViewModel GetValue();
    }
}
