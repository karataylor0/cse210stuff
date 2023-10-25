using System;

public class Product
{
    private string _productName;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product(string productName, string ProductID, int price, int quantity)
    {
        _productName = productName;
        _productID = ProductID;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public int FindTotalProductPrice()
    {
        return _quantity * _price;
    }
}