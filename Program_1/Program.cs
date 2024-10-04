using System;

class Program_1
{
    static void Main(string[] args)
    {
        var inventory = new Inventory();
        var menu = new Menu(inventory);
        menu.DisplayMenu();
    }
}
