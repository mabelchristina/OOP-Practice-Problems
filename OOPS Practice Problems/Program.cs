using OOPS_Practice_Problems.JSON_Inventory_Management;
using OOPS_Practice_Problems.Stock_Management;
using System;

namespace OOPS_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManagementMain inventoryMain = new InventoryManagementMain();
            StockManagementMain stock_ManagementMain = new StockManagementMain();
            Console.WriteLine("Choose 1.JSONInventoryDataManagement\n 2.Inventory Manager\n3.Display Stocks in Stock Management ");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    inventoryMain.ReadData(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\JSON Inventory Management\Inventory.json");
                    break;
                case 2:
                    inventoryMain.ReadData(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\JSON Inventory Management\Inventory.json");
                    Console.WriteLine("Enter Rice or Wheat or Pulses ");
                    inventoryMain.Display(Console.ReadLine());
                    break;
                case 3:
                    stock_ManagementMain.Display(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\Stock Management\Stock.json");
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
