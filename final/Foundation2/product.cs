using System;

public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;
    
    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public float CalculateTotal()
    {
        float total = 1.1f;
        return total;
    }
    public float GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public string GetName()
    {
        return _name;
    }
}