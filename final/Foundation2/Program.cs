using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Order order1 = new Order();

        Address address1 = new Address();
        address1.SetStreetAddress();
        address1.SetCity();
        address1.SetStateProvince();
        address1.SetCountry();
        
        Customer customer1 = new Customer("Bob Joe", address1);
        order1.AddCustomer(customer1);

        Product product1 = new Product("bananas","B001",2,3);
        Product product2 = new Product("potato chips", "P001", 5, 130);
        Product product3 = new Product("boat", "B999", 100000, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine($"\nPacking Label:\n{order1.GetStringPackingLabel()}");
        Console.WriteLine($"\nShipping Label:\n{order1.GetStringShippingLabel()}");
        Console.WriteLine($"Total: ${order1.GetGrandTotal()}");



        Order order2 = new Order();

        Address address2 = new Address();
        address2.SetStreetAddress();
        address2.SetCity();
        address2.SetStateProvince();
        address2.SetCountry();

        Customer customer2 = new Customer("Jill Smith", address2);
        order2.AddCustomer(customer2);

        Product product4 = new Product("laptop", "L468", 600, 3);
        Product product5 = new Product("bananas (organic)", "B002", 10, 90);
        Product product6 = new Product("banana bread", "B010", 0, 0);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Customer customer3 = new Customer("Jane Smith", address2);
        order2.AddCustomer(customer3);
        Product product7 = new Product("chocolate bar", "C310", 5, 1);
        order2.AddProduct(product7);

        Console.WriteLine($"\nPacking Label:\n{order2.GetStringPackingLabel()}");
        Console.WriteLine($"\nShipping Label:\n{order2.GetStringShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order2.GetGrandTotal()}");

    }
}