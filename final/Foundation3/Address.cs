using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private int _zipCode;

    public Address(string streetAddress, string city, string state, string country, int zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }
    public void DisplayStringAddress()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}, {_state}\n{_country}, {_zipCode}");
    }
    public string StringAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}, {_zipCode}";
    }
}