using System;
using System.Threading;
namespace InventoryAlertSystemEventsApp
{
    internal class Program
    {
        static void Main()
        {
            IInventoryItem item1 = new InventoryItem("Laptop", 20, 5);
            IInventoryItem item2 = new InventoryItem("Smartphone", 10, 2);

            IInventoryManager manager = new InventoryManager();

            // Subscribe to events
            item1.StockLow += manager.HandleLowStock;
            item1.StockOut += manager.HandleOutOfStock;

            item2.StockLow += manager.HandleLowStock;
            item2.StockOut += manager.HandleOutOfStock;

            // Simulation
            Console.WriteLine("Simulating inventory updates...");
            Thread.Sleep(1000);
            item1.RemoveStock(5);
            Thread.Sleep(1000);
            item1.RemoveStock(10);
            Thread.Sleep(1000);

            item2.RemoveStock(8);
            Thread.Sleep(1000);
            item2.RemoveStock(3);
            Thread.Sleep(1000);

            Console.WriteLine("Simulation completed.");
        }
    }
}
