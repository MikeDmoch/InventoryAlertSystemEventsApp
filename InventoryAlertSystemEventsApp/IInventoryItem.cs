using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAlertSystemEventsApp
{
    internal interface IInventoryItem // publisher
    {
        string Name { get; }
        int Stock {  get; }
        int LowStockThreshold { get; }

        event EventHandler<InventoryEventArgs> StockLow;
        event EventHandler<InventoryEventArgs> StockOut;

        void RemoveStock(int quantity);
    }
}
