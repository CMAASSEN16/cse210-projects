using System;

public class Order
{
    // Declaring variables
    private List<Product> products;
    private Customer customer;

    // Constructor for list and customer
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    //Gets the price for the order including determining shipping fees
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalPrice();
        }

        // If Else situation for the US non US shipping cost
        if (customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Returns packing label set up
    public string GetPackingLabel()
    {
        string label = "Packing Label: \n\n";
        foreach (Product product in products)
        {
            label += $"Product: \n  {product.GetName()}, ID: {product.GetId()}\n";
        }
        return label;
    }

    // Returns shipping label with customer info
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n\nName: \n  {customer.GetName()} \nAddress: \n  {customer.GetAddress().GetFullAddress()}";
    }
}