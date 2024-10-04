using System;

public class Menu
{
    private Inventory _inventory;

    public Menu(Inventory inventory)
    {
        _inventory = inventory;
    }

    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Inventory Management System ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Product Quantity");
            Console.WriteLine("4. Display Products");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    RemoveProduct();
                    break;
                case "3":
                    UpdateProduct();
                    break;
                case "4":
                    _inventory.DisplayProducts();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void AddProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Product Price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.Write("Enter Product Quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        var product = new Product(id, name, price, quantity);
        _inventory.AddProduct(product);
    }

    private void RemoveProduct()
    {
        Console.Write("Enter Product ID to remove: ");
        int id = int.Parse(Console.ReadLine());
        _inventory.RemoveProduct(id);
    }

    private void UpdateProduct()
    {
        Console.Write("Enter Product ID to update: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter new quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        _inventory.UpdateProduct(id, quantity);
    }
}

