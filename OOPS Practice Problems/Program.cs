using OOPS_Practice_Problems.JSON_Inventory_Management;
using System;

namespace OOPS_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1.JSONInventoryDataManagement");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    InventoryManagementMain inventoryMain = new InventoryManagementMain();
                    inventoryMain.DisplayData(@"D:\my git\OOP-Practice-Problems\OOPS Practice Problems\JSON Inventory Management\Inventory.json");
                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }
        }
    }
}
