class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "001", 1200m, 1);
        Product product2 = new Product("Mouse", "002", 20m, 2);
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Keyboard", "003", 100m, 1);
        Product product4 = new Product("Monitor", "004", 200m, 1);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
