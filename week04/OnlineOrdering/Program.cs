using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Maple Street", "Rexburg", "Idaho", "USA");
        Customer usaCustomer = new Customer("Alex Morgan", usaAddress);
        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(new Product("Notebook", "NB-101", 4.50m, 3));
        usaOrder.AddProduct(new Product("Pen Set", "PN-202", 6.00m, 2));

        Address brazilAddress = new Address("Rua das Flores, 100", "Sao Paulo", "SP", "Brazil");
        Customer brazilCustomer = new Customer("Marina Costa", brazilAddress);
        Order brazilOrder = new Order(brazilCustomer);
        brazilOrder.AddProduct(new Product("Keyboard", "KB-303", 29.99m, 1));
        brazilOrder.AddProduct(new Product("Mouse", "MS-404", 14.50m, 2));

        List<Order> orders = new List<Order> { usaOrder, brazilOrder };
        int orderNumber = 1;

        Console.WriteLine("ONLINE ORDERING");
        Console.WriteLine();

        foreach (Order order in orders)
        {
            Console.WriteLine($"ORDER {orderNumber}");
            Console.WriteLine("Packing label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total (USD, including shipping): ${order.GetTotalCost().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            orderNumber++;
        }
    }
}
