using InventoryManagement.Services;

var service = new InventoryService();

while (true)
{
    Console.WriteLine("\n=== Inventory Management ===");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. View Products");
    Console.WriteLine("3. Search Product");
    Console.WriteLine("4. Delete Product");
    Console.WriteLine("5. Exit");
    Console.Write("Choose: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            service.AddProduct();
            break;
        case "2":
            service.ViewProducts();
            break;
        case "3":
            service.SearchProduct();
            break;
        case "4":
            service.DeleteProduct();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}


/*
using InventoryManagement.Services;

var service = new InventoryService();

while (true)
{
    Console.WriteLine("\n=== Inventory Management ===");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. View Products");
    Console.WriteLine("3. Search Product");
    Console.WriteLine("4. Delete Product");
    Console.WriteLine("5. Exit");
    Console.Write("Choose: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            service.AddProduct();
            break;
        case "2":
            service.ViewProducts();
            break;
        case "3":
            service.SearchProduct();
            break;
        case "4":
            service.DeleteProduct();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}
*/
