using OOPS_Practice_Problems.JSON_Inventory_Management;
using OOPS_Practice_Problems.Stock_Management;
using OOPS_Practice_Problems.StockCommercialDataManagement;
using System;

namespace OOPS_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManagementMain inventoryMain = new InventoryManagementMain();
            StockManagementMain stockManagementMain = new StockManagementMain();
            StockAccount stockAccount = new StockAccount();
            Console.WriteLine("Choose 1.JSONInventoryDataManagement\n 2.Inventory Manager\n3.Display Stocks in Stock Management\n4.Stock Display\n 5.Total Value of Stock\n6.Buy Shares\n7.Sell\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
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
                    stockManagementMain.Display(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\Stock Management\Stock.json");
                    break;
                case 4:
                    stockAccount.CreateStock(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\StockCommercialDataManagement\Stock.json");
                    break;
                case 5:
                    stockAccount.TotalValue(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\StockCommercialDataManagement\Stock.json");
                    break;
                case 6:
                    stockAccount.BuyShares(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\StockCommercialDataManagement\Stock.json", @"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\StockCommercialDataManagement\Account.json");
                    break;
                case 7:
                    stockAccount.SellShares(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\StockCommercialDataManagement\Stock.json", @"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\StockCommercialDataManagement\Account.json");
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
