using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAlertSystemEventsApp
{
    internal class InventoryItem : IInventoryItem
    {
        public string Name { get; private set; }

        public int Stock { get; private set; }

        public int LowStockThreshold { get; private set; }

        public event EventHandler<InventoryEventArgs> StockLow;
        public event EventHandler<InventoryEventArgs> StockOut;

        public void RemoveStock(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be positive.");

            Stock -= quantity;
            Stock = Math.Max(Stock, 0);
            Console.WriteLine($"Product: {Name}, Stock: {Stock}");

            if (Stock == 0) OnStockOut();
            else if (Stock <= LowStockThreshold) OnStockLow();
        }
        public InventoryItem(string name, int initialStock, int lowStockThreshold)
        {
            Name = name;
            Stock = initialStock;
            LowStockThreshold = lowStockThreshold;
        }
        protected virtual void OnStockOut()
        {
            StockOut?.Invoke(this, new InventoryEventArgs(Name, Stock));
        }
        protected virtual void OnStockLow()
        {
            StockLow?.Invoke(this, new InventoryEventArgs(Name, Stock));
        }
    }
}
