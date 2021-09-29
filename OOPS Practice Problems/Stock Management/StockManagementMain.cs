using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPS_Practice_Problems.Stock_Management
{
    class StockManagementMain
    {
        StockModel stockModel = new StockModel();
        List<StockModel> stockModels = new List<StockModel>();
        public void Display(string filepath)
        {
            try
            {
                using (StreamReader reader=new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("Name\tNumber of Shares\tPrice");
                    foreach (var item in items)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.NumberOfShares, item.Price);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
  