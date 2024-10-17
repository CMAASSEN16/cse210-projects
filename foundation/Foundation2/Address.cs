using System;

public class Address
{
    // Initializing variables
    private string streetAddress;
    private string city;
    private string stateOrProvince;
    private string country;

    // Constructor that pulls the full address information
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    // Will send a true statement if country is in "USA" otherwise it will be false
    public bool IsInUSA()
    {
        return country == "USA";
    }

    // Returns full address
    public string GetFullAddress()
    {
        return $"{streetAddress} \n  {city}, {stateOrProvince} \n  {country}";
    }
}