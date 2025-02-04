using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = products.Sum(product => product.GetTotalCost());
        double shippingCost = customer.IsInNIGERIA() ? 5.00 : 35.00;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        var packingLabel = new StringBuilder();
        foreach (var product in products)
        {
            packingLabel.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress()}";
    }
}
