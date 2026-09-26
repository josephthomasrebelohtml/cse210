using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
        Product product1List1 = new Product("27 inch 1080p Gaming Monitor 144hz", "430792615803", 199.99, 1);
        Product product2List1 = new Product("VESA Certified DisplayPort Cable 1.4", "927418503261", 20.50, 2);
        Product product3List1 = new Product("Single Monitor Desk Mount 10kg Capacity", "583104927615", 60.00, 1);
        products1.Add(product1List1);
        products1.Add(product2List1);
        products1.Add(product3List1);
        Address address1 = new Address("123 Flowery Street", "Detroit", "Michigan", "USA");
        Customer customer1 = new Customer("John Jack",address1);
        Order order1 = new Order(products1, customer1);

        Console.WriteLine($"Total: ${order1.CalculateTotal()}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("");
        List<Product> products2 = new List<Product>();
        Product product1List2 = new Product("Premium Protein Powder Chocolate Flavor 907g", "614829375206", 69.99, 2);
        Product product2List2 = new Product("Pre Workout Supplement Green Apple Flavor 500g", "205793841627", 27.59, 1);
        Product product3List2 = new Product("Electric 28oz Shaker Water Bottle", "491638275904", 24.99, 1);
        products2.Add(product1List2);
        products2.Add(product2List2);
        products2.Add(product3List2);
        Address address2 = new Address("932 Kingston Street", "London", "Ottawa", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine($"Total: ${order2.CalculateTotal()}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

    }
}