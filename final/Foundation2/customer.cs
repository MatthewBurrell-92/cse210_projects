using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool DomesticOrNot()
    {
        if (_address.DomesticOrNot())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // public string GetName()
    // {
    //     return _name;
    // }
    // public Address GetAddress()
    // {
    //     return _address;
    // }

    public string GetShippingInfo()
    {
        string shippingInfo = $"{_name}\n{_address.GetAddress()}";
        return shippingInfo;
    }
}