namespace ADVC_02
{

    #region solution
    //using System;
    //using System.Collections.Generic;

    //internal class Program
    //{
    //    #region Task 01 

    //    static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    //    {
    //        List<Product> result = new List<Product>();

    //        foreach (Product product in products)
    //        {
    //            if (filter(product))
    //            {
    //                result.Add(product);
    //            }
    //        }

    //        return result;
    //    }

    //    #endregion

    //    #region Task 03.1

    //    static void PrintReport(List<Product> products, Action<Product> action)
    //    {
    //        foreach (Product product in products)
    //        {
    //            action(product);
    //        }
    //    }

    //    #endregion

    //    #region Task 3.2 - Transform Products

    //    static List<string> TransformProducts(
    //        List<Product> products,
    //        Func<Product, string> function)
    //    {
    //        List<string> result = new List<string>();

    //        foreach (Product product in products)
    //        {
    //            result.Add(function(product));
    //        }

    //        return result;
    //    }

    //    #endregion

    //    #region Task 3.3 - Filter Products

    //    static List<Product> FilterProducts(
    //        List<Product> products,
    //        Predicate<Product> condition)
    //    {
    //        List<Product> result = new List<Product>();

    //        foreach (Product product in products)
    //        {
    //            if (condition(product))
    //            {
    //                result.Add(product);
    //            }
    //        }

    //        return result;
    //    }

    //    #endregion

    //    static void Main(string[] args)
    //    {
    //        #region Product Catalog

    //        List<Product> catalog = new List<Product>
    //    {
    //        new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
    //        new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
    //        new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
    //        new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
    //        new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
    //        new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
    //        new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
    //        new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
    //        new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
    //        new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
    //    };

    //        #endregion

    //        #region Task 01

    //        List<Product> electronics =
    //            SearchProducts(catalog, p => p.Category == "Electronics");

    //        Console.WriteLine("--- Electronics ---");

    //        foreach (Product product in electronics)
    //        {
    //            Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
    //        }

    //        List<Product> under50 =
    //            SearchProducts(catalog, p => p.Price < 50);

    //        Console.WriteLine("--- Under $50 ---");

    //        foreach (Product product in under50)
    //        {
    //            Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
    //        }

    //        List<Product> inStock =
    //            SearchProducts(catalog, p => p.Stock > 0);

    //        Console.WriteLine("--- In Stock ---");

    //        foreach (Product product in inStock)
    //        {
    //            Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
    //        }

    //        List<Product> clothingUnder100 =
    //            SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);

    //        Console.WriteLine("--- Clothing Under $100 ---");

    //        foreach (Product product in clothingUnder100)
    //        {
    //            Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
    //        }

    //        #endregion

    //        #region Task 03.1

    //        Console.WriteLine("--- Short Report ---");

    //        PrintReport(catalog, p =>
    //        {
    //            Console.WriteLine($"{p.Name} - ${p.Price}");
    //        });

    //        Console.WriteLine("--- Detailed Report ---");

    //        PrintReport(catalog, p =>
    //        {
    //            Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}");
    //        });

    //        #endregion

    //        #region Task 03.2

    //        List<string> summaryList =
    //            TransformProducts(catalog, p => $"{p.Name} (${p.Price})");

    //        Console.WriteLine("--- Summary List ---");

    //        foreach (string item in summaryList)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        List<string> priceLabels =
    //            TransformProducts(catalog,
    //                p => p.Price > 100 ? "Expensive!" : "Affordable");

    //        Console.WriteLine("--- Price Labels ---");

    //        for (int i = 0; i < catalog.Count; i++)
    //        {
    //            Console.WriteLine($"{catalog[i].Name}: {priceLabels[i]}");
    //        }

    //        #endregion

    //        #region Task 03.3

    //        List<Product> lowStock =
    //            FilterProducts(catalog, p => p.Stock < 20);

    //        Console.WriteLine("--- Low-Stock Alert ---");

    //        foreach (Product product in lowStock)
    //        {
    //            Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
    //        }

    //        #endregion
    #endregion

        }
  