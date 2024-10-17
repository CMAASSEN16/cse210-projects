using System;

public class Customer
{
    // Variables with Address as an object 
    private string name;
    private Address address;

    // Constructor for customer name and address
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Returns customer name
    public string GetName()
    {
        return name;
    }
    
    // Returns customer's address as an address object
    public Address GetAddress()
    {
        return address;
    }

    // Determiner if the customer lives in the US or not.
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}