using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public bool IsAmerican()
    {
        if (_country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetCountry()
    {
        return _country;
    }
    public string GetCompleteAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
    public void SetStreetAddress()
    {
        Console.WriteLine("Street Address:");
        _streetAddress = Console.ReadLine();
    }
    public void SetCity()
    {
        Console.WriteLine("City:");
        _city = Console.ReadLine();
    }
    public void SetStateProvince()
    {
        Console.WriteLine("State / Province:");
        _stateProvince = Console.ReadLine();
    }
    public void SetCountry()
    {
        Console.WriteLine("Country:");
        _country = Console.ReadLine();
    }
}