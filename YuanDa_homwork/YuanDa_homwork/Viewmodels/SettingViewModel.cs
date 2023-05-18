using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
namespace YuanDa_homwork.Viewmodels
{
    internal class SettingViewModel : BaseViewModel
    {
        public SettingViewModel()
        {

        }

        private int _refreshRate = 3000;
        public int RefreshRate
        {
            get => _refreshRate;
            set
            {
                int result;
                //to setup the boundary of refresh rate
                if (value >= 3000)
                    result = 3000;
                else if (value <= 10)
                    result = 10;
                else
                    result = value;
                SetProperty(ref _refreshRate, result);

                //todo: need a global set function here to set the refresh rate.
            }
        }
    }
}
