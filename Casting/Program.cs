using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebbook1 = new Notebook();
            Notebook notebbook2 = new Notebook();
            Store.NotebookLimit = 2;
            notebbook1.Name = "hjhhj";
            notebbook1.Price = 200;
            notebbook1.No = "1";
            notebbook2.Name = "sdds";
            notebbook2.Price = 2300;
            notebbook2.No = "2";
            Store store1 = new Store();
            store1.AddProduct(notebbook1);
            store1.AddProduct(notebbook2);
            Console.WriteLine(store1.CalcNotebookAvg());
            
       



        }
    }
}
