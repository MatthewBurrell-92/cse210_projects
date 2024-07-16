using System;

public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public decimal CalculateTotal()
    {
        decimal total = _price * _quantity;
        return total;
    }
    public decimal GetPrice()
    {
        return _price;
    }
    // public int GetQuantity()
    // {
    //     return _quantity;
    // }
    // public string GetName()
    // {
    //     return _name;
    // }

    public string GetProductInfo()
    {
        string packingInfo = $"{_name}, ID:{_productId}";
        return packingInfo;
    }
}