using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAlertSystemEventsApp
{
    internal interface IInventoryManager
    {
        void HandleLowStock(object sender, EventArgs e);
        void HandleOutOfStock(object sender, EventArgs e);
    }
}
