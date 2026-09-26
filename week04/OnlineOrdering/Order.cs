using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    
    public Order(List<Product> products,Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotal()
    {
        double total = 0;

        if (_customer.IsAmericanOrNot() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        foreach (Product product in _products)
        {
            total += product.CalculateProductTotal();
        }

        return total;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingDetails();
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductDetails();
        }
        return packingLabel;
    }


}