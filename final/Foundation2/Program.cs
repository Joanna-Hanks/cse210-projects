using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("123 Peekaboo St", "Bald Head Island", "North Carolina", "USA");
        Address address3 = new Address("523 Westminister Ave", "Toronto", "Ontario", "Canada");

        Customer customer1 = new Customer("Studently Student", address1);
        Customer customer2 = new Customer("Baldo Waldo", address2);
        Customer customer3 = new Customer("John Owl", address3);

        Product p1 = new Product("Keyboard", 101, 30.00, 2);
        Product p2 = new Product("Mouse", 102, 15.00, 1);
        Product p3 = new Product("Monitor", 103, 200.00, 1);
        Product p4 = new Product("Headphones", 104, 60.00, 2);
        Product p5 = new Product("Laptop", 105, 1500.00, 1);
        Product p6 = new Product("Tablet", 106, 99.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        Order order3 = new Order(customer3);
        order3.AddProduct(p5);
        order3.AddProduct(p6);

        List<Order> orders = new List<Order>();

        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"ORDER {orderNumber}");
            Console.WriteLine();

            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");

            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            orderNumber++;
        }
    }
}