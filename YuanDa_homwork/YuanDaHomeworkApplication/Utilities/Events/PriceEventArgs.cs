using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuanDaHomeworkApplication.Utilities.Events
{
    internal class PriceEventArgs : EventArgs
    {
        public string StockId { get; set; }
        public string StockName { get; set; }
        public double Price { get; set; }

        public PriceEventArgs(string stockId, string stockName, double price)
        {
            StockId = stockId;
            StockName = stockName;
            Price = price;
        }
    }
}
