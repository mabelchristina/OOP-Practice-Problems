using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Practice_Problems.JSON_Inventory_Management
{
    class InventoryFactory
    {
        public List<InventoryModel> Rice { get; set; }
        public List<InventoryModel> Wheat { get; set; }
        public List<InventoryModel> Pulses { get; set; }
    }
}
