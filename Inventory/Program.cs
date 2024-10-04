using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        _products.Add(product);
        Console.WriteLine("Product added successfully.");
    }

    public void RemoveProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
            Console.WriteLine("Product removed successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void UpdateProduct(int id, int quantity)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            product.Quantity = quantity;
            Console.WriteLine("Product updated successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Current Inventory:");
        foreach (var product in _products)
        {
            Console.WriteLine(product);
        }
    }
}
