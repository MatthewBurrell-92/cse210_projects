using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void DisplayPackingLabel()
    {
        // not dun
        Console.WriteLine("Things");
    }
    public void DisplayPackingLabel()
    {
        // name and id of each product
    }
    public float CalculatePrice()
    {
        float totalPrice = 0;
        float shippingPrice;
        if (_customer.DomesticOrNot())
        {
            shippingPrice = 5.00f;
        }
        else
        {
            shippingPrice = 35.00f;
        }
        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
        }
        totalPrice += shippingPrice;
        return totalPrice;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
}