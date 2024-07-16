using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("333 N 3rd East", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Holly", address1);

        Address address2 = new Address("1930 Riverlawn Dr", "Kingwood", "Texas", "USA");
        Customer customer2 = new Customer("Amanda", address2);

        Product dogTreats = new Product("Dog Treats", 8675309, 0.99M, 30);
        Product dogToys = new Product("Dog Toys", 123456, 15.00M, 2);
        Product dogLeash = new Product("Leash", 9035768, 32.50M, 1);

        Product novel = new Product("49 Shades of Gray", 9780345, 35.99M, 1);
        Product game = new Product("Legend of Zelda", 3, 64.99M, 1);
        Product wine = new Product("Cheap wine", 77, 2.50M, 100);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProducts(dogTreats);
        order1.AddProducts(dogToys);
        order1.AddProducts(dogLeash);

        order2.AddProducts(novel);
        order2.AddProducts(game);
        order2.AddProducts(wine);

        ViewOrder(order1);
        ViewOrder(order2);
    }
    static void ViewOrder(Order orderToBeViewed)
    {
        Console.WriteLine("Packing Label: \n");
        orderToBeViewed.DisplayPackingLabel();
        Console.WriteLine("\nShipping Label: \n");
        orderToBeViewed.DisplayShippingLabel();
        Console.WriteLine("\nTotal Price: \n");
        Console.WriteLine($"${orderToBeViewed.CalculatePrice()}");
    }
}