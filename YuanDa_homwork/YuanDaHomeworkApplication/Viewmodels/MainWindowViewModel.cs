using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using YuanDaHomeworkApplication.Models;
namespace YuanDaHomeworkApplication.Viewmodels
{
    internal class MainFormViewModel : BaseViewModel
    {
        public List<Stock> stocks = new List<Stock>();
        public MainFormViewModel() 
        {

        }
    }
}
