using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuanDaHomeworkApplication.Utilities
{
    internal class DataUpdateEvent
    {
        public event EventHandler? _eventHandler;
        public void OnEventCall(EventArgs e)
        {
            _eventHandler?.Invoke(this, e);
        }
    }
}
