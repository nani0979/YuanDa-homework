using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using YuanDaHomeworkApplication.Models;
namespace YuanDaHomeworkApplication.Utilities
{
    internal class Storage
    {
        public static Storage Instance { get; private set; } = new Storage();

        public Storage() { }

        #region Read
        public List<Stock> getStockFromResource()
        {
            //TODO define the resource path.
            string filePath = Path.Combine("", "");
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                List<Stock>? stocks = JsonConvert.DeserializeObject<List<Stock>>(jsonString);
                if (stocks is not null) return stocks;
            }
            return new List<Stock>();
        }
        #endregion
    }
}
