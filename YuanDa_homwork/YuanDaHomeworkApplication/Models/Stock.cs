using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YuanDaHomeworkApplication.Models
{
    internal class Stock : INotifyPropertyChanged
    {
        public Stock()
        {
            this.HistoryPrices = new List<double>();
        }

        public Stock(string stockId, string stockName)
        {
            this.StockId = stockId;
            this.StockName = stockName;
            this.HistoryPrices = new List<double>();
        }

        //primary key.
        public string StockId { get; set; }
        public string StockName { get; set; }

        //the price previous day.
        public double previousClosedPrice { get; set; }

        //the max price today.
        private double _maxPrice;
        public double MaxPrice
        {
            get => _maxPrice;
            set => SetProperty(ref _maxPrice, value);
        }
        private double _currentPrice;
        public double CurrentPrice
        {
            get => CurrentPrice;
            set => SetProperty(ref _currentPrice, value);
        }
        private double _miniPrice;
        public double MiniPrice
        {
            get => _miniPrice;
            set => SetProperty(ref _miniPrice, value);
        }

        private double _increaseRate;
        public double IncreaseRate
        {
            get => _increaseRate;
            set => SetProperty(ref _increaseRate, value);
        }

        public List<double> HistoryPrices { get; set; }

        private DateTime _lastUpdateTime;
        public DateTime LastUpdateTime
        {
            get => _lastUpdateTime;
            set => SetProperty(ref _lastUpdateTime, value);
        }

        public void UpdateStockPrice(double price)
        {
            MaxPrice = Math.Max(price, MaxPrice);
            MiniPrice = Math.Min(price, MiniPrice);
            CurrentPrice = Math.Min(price, CurrentPrice);
            LastUpdateTime = DateTime.Now;

            //it would cause crash if the previous price is 0.
            IncreaseRate =
                previousClosedPrice == 0 ?
                0 : (price - previousClosedPrice) / previousClosedPrice;

            HistoryPrices.Add(price);
            //the list should update if the price is changed.
            OnPropertyChanged(nameof(HistoryPrices));
        }

        /*To implement the function to notify the ui that the price is changed.*/
        #region
        protected void SetProperty<T>(ref T property, T value)
        {
            if (value.Equals(property))
            {
                property = value;
                OnPropertyChanged();
            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
