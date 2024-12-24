using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAlertSystemEventsApp
{
    internal class InventoryEventArgs : EventArgs
    {
        public string ProductName { get; set; }
        public int CurrentStock { get; set; }

        public InventoryEventArgs(string productName, int currentStock)
        {
            ProductName = productName;
            CurrentStock = currentStock;
        }
    }
}
