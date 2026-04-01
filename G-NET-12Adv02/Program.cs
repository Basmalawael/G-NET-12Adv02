using G_NET_12Adv02.OnlineStore;
using System.Linq;
namespace G_NET_12Adv02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Catalog
            /*
            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }

            };

            //    foreach (var item in catalog)
            //    {
            //        Console.WriteLine(item); 
            //    }
            */
            #endregion


            #region Task 01 : Smart Product Search
            /*

            Console.WriteLine("--- Electronics ---");

            var electronic = ProductService.SearchProducts(catalog, p => p.Category == "Electronics");

            foreach (var item in electronic)
            {
                Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            }

            Console.WriteLine();

            //--------------------------------------------------------------------------

            Console.WriteLine("---Under $50 ---");

            var cheapProducts = ProductService.SearchProducts(catalog, p => p.Price < 50);

            foreach (var item in cheapProducts)
            {
                Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            }

            Console.WriteLine();

            //------------------------------------------------------------------------

            Console.WriteLine("--- In Stock ---");

            var instock = ProductService.SearchProducts(catalog, p => p.Stock > 0);

            int count = 0;

           foreach (var item in instock)
            {
                if (count >= 4) break;
                    

                Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
                count++;
            }

            Console.WriteLine();
            //----------------------------------------------------------------------

            Console.WriteLine("---Clothing Under $100 ---");

            var cheapClothing = ProductService.SearchProducts(catalog , p => p.Category== "Clothing" && p.Price < 100);

            foreach (var item in cheapClothing)
            {
                Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            }
            */
            #endregion


            #region Task 03 : Custom Report Generator

            #region Short & Detailed
            /*
            Console.WriteLine("--- Short Report ---");

            PrintRet.PrintReport(catalog.Take(6).ToList(), p => Console.WriteLine($"{p.Name} - ${p.Price}"));

            Console.WriteLine();

            //------------------------------------------------

            Console.WriteLine("--- Detailed Report ---");

            PrintRet.PrintReport(catalog.Take(7).ToList(),

               p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));
            */
            #endregion


            #region Summary
            /*
            Console.WriteLine("--- Summary List ---");
            var summaries = TransformPro.TransformProducts(catalog.Take(7).ToList(), p => $"{p.Name} (${p.Price})");

            foreach (var line in summaries)
            {
                Console.WriteLine(line);
            }

            //==========================================================================

            Console.WriteLine();

            Console.WriteLine("--- Price Labels ---");

            var labels = TransformPro.TransformProducts(catalog, 
                p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}");

            foreach (var label in labels)
            {
                Console.WriteLine(label);
            }
            */
            #endregion

            #region Low_Stock
            /*
            Console.WriteLine("--- Low-Stock Alert ---");

            var filterstock = FilterPred.FilterProducts(catalog, p => p.Stock < 20);

            foreach (var p in filterstock)
            {
                Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
            }
            */
            #endregion

            #endregion
        }
    }
}
