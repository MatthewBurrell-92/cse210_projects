using System;

class Program
{
    static void Main(string[] args)
    {
        // Make sure that all member variables are private and getters, setters, and constructors are created as needed.
        // Once you have created these classes, write a program that creates at least two orders with a 2-3 products each.
        // Call the methods to get the packing label, the shipping label, and the total price of the order, and display
        // the results of these methods.

        Address address1 = new Address("333 N 3rd East", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Holly", address1);

        Address address2 = new Address("1930 Riverlawn Dr", "Kingwood", "Texas", "USA");
        Customer customer2 = new Customer("Amanda", address2);

        Product dogTreats = new Product("Dog Treats", 8675309, 8.99f, 30);
        Product dogToys = new Product("Dog Toys", 123456, 15.00f, 2);
        Product dogLeash = new Product("Leash", 9035768, 32.50f, 1);

        Product novel = new Product("49 Shades of Gray", 9780345, 35.99f, 1);
        Product game = new Product("Legend of Zelda", 3, 64.99f, 1);
        Product wine = new Product("Case of cheap wine", 77, 250.00f, 25);
    }
}