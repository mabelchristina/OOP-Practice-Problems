using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPS_Practice_Problems.StockCommercialDataManagement
{
    public class StockAccount
    {

        StockModel stockModel = new StockModel();
        List<StockModel> stockModels = new List<StockModel>();
        List<TransactionModel> transactionModels = new List<TransactionModel>();
        public void CreateStock(string filepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("Name\tNumber of Shares\tPrice");
                    foreach (var item in items)
                    {
                        Console.WriteLine("Total value" + item.value);
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", item.Name, item.NumOfShares, item.Price);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void TotalValue(string filepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    stockModels = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    foreach (var item in stockModels)
                    {
                        item.value = item.NumOfShares * item.Price;
                    }

                }
                string Value = JsonConvert.SerializeObject(stockModels);
                File.WriteAllText(filepath, Value);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void BuyShares(string stockfilepath, string accountfilepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(stockfilepath))
                {
                    var json = reader.ReadToEnd();
                    var itemsToBuy = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("Enter the number of stock you want to buy:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the company name:");
                    string name = Console.ReadLine();
                    TransactionModel transactionModel = new TransactionModel();
                    transactionModel.Company = name;
                    foreach (var item in itemsToBuy)
                    {
                        if (item.Name == name)
                        {
                            transactionModel.Transactiondetails = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            transactionModel.PriceOfShare = item.Price;
                            transactionModel.NumberOfShare -= num;
                            item.value = item.NumOfShares * item.Price;
                        }
                    }
                    reader.Close();
                    string transactionNewData = JsonConvert.SerializeObject(stockModel);
                    Console.WriteLine();
                    File.WriteAllText(stockfilepath, transactionNewData);
                    string StockNewData = JsonConvert.SerializeObject(transactionModel);
                    File.WriteAllText(accountfilepath, StockNewData);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void SellShares(string stockfilepath, string accountfilepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(stockfilepath))
                {
                    var json = reader.ReadToEnd();
                    var itemsToBuy = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("Enter the number of stock you want to buy:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the company name:");
                    string name = Console.ReadLine();
                    TransactionModel transactionModel = new TransactionModel();
                    transactionModel.Company = name;
                    foreach (var item in itemsToBuy)
                    {
                        if (item.Name == name)
                        {
                            transactionModel.Transactiondetails = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                            transactionModel.PriceOfShare += item.Price;
                            transactionModel.NumberOfShare += num;
                            item.value = item.NumOfShares * item.Price;
                        }
                    }
                    reader.Close();
                    string transactionNewData = JsonConvert.SerializeObject(stockModel);
                    Console.WriteLine();
                    File.WriteAllText(stockfilepath, transactionNewData);
                    string StockNewData = JsonConvert.SerializeObject(transactionModel);
                    File.WriteAllText(accountfilepath, StockNewData);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}