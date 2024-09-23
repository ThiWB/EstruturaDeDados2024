using System;
using System.Collections;

namespace ProductLocation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating and initializing a dictionary
            Dictionary<string, string> productLocations = new Dictionary<string,string>
            {
                // Adding key-value pairs to the dictionary
                {"5900000000000", "A1"},
                {"5901111111111", "B5"},
                {"5902222222222", "C9"}

            };

            // Adding a new key-value pair to the dictionary
            productLocations["5903333333333"] = "D2";

            try
            {
                // Adding a key-value pair to the dictionary with a different method 
                productLocations.Add("5904444444444", "E3");
            }
            catch (ArgumentException)
            {
                // If the key already exists, catch the exception and display a message
                Console.WriteLine("Product already exists!");
            }

            Console.WriteLine("All Products: ");

            // If there are no products, display a message
            if(productLocations.Count == 0)
            {
                Console.WriteLine("No products found!");
            }

            else
            {
                // Iterate through the dictionary and display the key-value pairs
                foreach (KeyValuePair<string, string> product in productLocations)
                {
                    Console.WriteLine($"Product ID: {product.Key}, Location: {product.Value}");
                }
            }

            Console.WriteLine();

            // Search manually for a product with the ID
            Console.WriteLine("Search by Product ID: ");
            string productId = Console.ReadLine();

            if(productLocations.TryGetValue(productId, out string location))
            {
                // If the product is found, display the location
                Console.WriteLine($"The product is located at {location}.");
            }

            else
            {
                // If the product is not found, display a message
                Console.WriteLine("Product not found!");
            }
        }
    }
}