using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    class Store
    {
        public static int NotebookLimit { get; set; }
        public static int PhoneLimit { get; set; }
        Product[] Products = new Product[0];
        Product[] notebooks = new Product[0];
        Product[] phones = new Product[0];
        public void AddProduct(Product products)
        {
            if (products is Notebook)
            {
                Array.Resize(ref notebooks, notebooks.Length + 1);
                notebooks[notebooks.Length - 1] = products;
                if (notebooks.Length <= NotebookLimit)
                {
                    Console.WriteLine("Limit asilmamalidir");
                }
            }
            else if (products is Phone)
            {
                Array.Resize(ref phones, phones.Length + 1);
                notebooks[phones.Length - 1] = products;
                if (phones.Length <= PhoneLimit)
                {
                    Console.WriteLine("Limit asilmamalidir");
                }
            }
        }
        public string FindByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (no == Products.No)
                {
                    return Products[i].Name;
                }
            }
            return "tapilmir";
        }
        public double CalcNotebookAvg()
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                if (Products[i] is Notebook)
                {
                    Notebook notebooks1 = Products[i] as Notebook;
                    count++;
                    sum += notebooks1.Price * (100 - notebooks1.DiscountedPercent) / 100;
                }
            }
            return sum / count;
        }
        public double CalcPhoneAvg()
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < phones.Length; i++)
            {
                if (Products[i] is Phone)
                {
                    Phone phoness = Products[i] as Phone;
                    count++;
                    sum += phoness.Price * (100 - phoness.DiscountedPercent) / 100;
                }
            }
            return sum / count;
        }
}   }
