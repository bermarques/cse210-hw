using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", "A123", 800.00, 1);
        Product product2 = new Product("Mouse", "B456", 20.00, 2);
        Product product3 = new Product("Keyboard", "C789", 50.00, 1);
        Product product4 = new Product("Monitor", "D012", 150.00, 2);
        Product product5 = new Product("Printer", "E345", 200.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);

    }

    private static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order.CalculateTotalCost()}");
        Console.WriteLine();
    }
}