using System;

public class Customer
{
    private string _name;
    private Address _address = new Address("", "", "", "");

    public Customer(string customerName, Address customerAddress)
    {
        _name = customerName;
        _address = customerAddress;
    }

    public Customer()
    {
    }
    public bool IsAmericanOrNot()
    {
        return _address.AmericanOrNot();
    }

    public string GetShippingDetails()
    {
        string customerDetails = $"{_name}\n";
        customerDetails += _address.GetAddressDisplay();

        return customerDetails;

    }
}