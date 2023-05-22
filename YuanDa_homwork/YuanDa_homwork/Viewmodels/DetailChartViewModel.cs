using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using YuanDa_homwork.Models;

namespace YuanDa_homwork.Viewmodels
{
    internal class DetailChartViewModel : BaseViewModel
    {
        private Stock _stock;
        public DetailChartViewModel(Stock stock)
        {
            _stock = stock;
        }

        public DetailChartViewModel()
        {
            _stock = new Stock();
        }
    }
}
