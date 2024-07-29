using System;
using System.Collections.Generic;
using System.Linq;

namespace Assign_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> ProductPrices = new Dictionary<string, double>();

            ProductPrices.Add("Dairymilk",100);
            ProductPrices.Add("Curd", 80);
            ProductPrices.Add("Toothpaste",55);
            ProductPrices.Add("Pickle", 125);
            ProductPrices.Add("Sprite", 90);

            Console.WriteLine("Product Prices:");
            foreach (var product in ProductPrices)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            double averagePrice = ProductPrices.Values.Average();
            Console.WriteLine($"\nAverage Price: {averagePrice}");

            var mostExpensiveProduct = ProductPrices.OrderByDescending(x => x.Value).First();

            Console.WriteLine($"\nMost Expensive Product: {mostExpensiveProduct.Key} - {mostExpensiveProduct.Value}");
        }
    }
}