using System;

public class Product
{
    // Initializing storage of variables
    private string name;
    private string id;
    private double price;
    private int quantity;

    // Constructor to put info together using this keyword for the current instance
    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    // Returns product name
    public string GetName()
    {
        return name;
    }

    // Returns Product ID
    public string GetId()
    {
        return id;
    }

    // Gets total price of products ordered
    public double GetTotalPrice()
    {
        return price * quantity;
    }
}