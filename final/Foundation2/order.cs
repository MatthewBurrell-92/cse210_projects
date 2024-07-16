using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProducts(Product productToBeAdded)
    {
        _products.Add(productToBeAdded);
    }
    public void DisplayPackingLabel()
    {
        // product name and ID
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductInfo());
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetShippingInfo());
    }
    public decimal CalculatePrice()
    {
        decimal totalPrice = 0;
        decimal shippingPrice;
        if (_customer.DomesticOrNot())
        {
            shippingPrice = 5.00m;
        }
        else
        {
            shippingPrice = 35.00m;
        }
        foreach (Product product in _products)
        {
            totalPrice += product.CalculateTotal();
        }
        totalPrice += shippingPrice;
        return totalPrice;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
}