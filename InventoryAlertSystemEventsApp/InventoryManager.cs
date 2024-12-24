using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAlertSystemEventsApp
{
    internal class InventoryManager : IInventoryManager
    {
        public void HandleLowStock(object sender, EventArgs e)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING] Product '{{e.ProductName}}' has low stock: {{e.CurrentStock}} units left");
            Console.ResetColor();
        }

        public void HandleOutOfStock(object sender, EventArgs e)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[CRITICAL] Product '{{e.ProductName}}' is out of stock!");
            Console.ResetColor();
        }
    }
}
