using System;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private List<Customer> _customerList = new List<Customer>();

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
    public void AddCustomer(Customer newCustomer)
    {
        _customerList.Add(newCustomer);
    }
    public int GetGrandTotal()
    {
        int grandTotal = 0;
        foreach (Product product in _productList)
        {
            grandTotal += product.FindTotalProductPrice();
        }
        foreach (Customer customer in _customerList)
        {
            if (customer.IsAmericanCustomer() == true)
            {
                grandTotal += 5;
            }
            else
            {
                grandTotal += 35;
            }
        }
        return grandTotal;
    }
    public string GetStringPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productList)
        {
            packingLabel = packingLabel + $"{product.GetName()}: {product.GetProductID()}\n";
        }
        return packingLabel;
    }
    public string GetStringShippingLabel()
    {
        string shippingLabel = "";
        foreach (Customer customer in _customerList)
        {
            shippingLabel = shippingLabel + $"{customer.GetCustomerName()}: {customer.GetAddress().GetCompleteAddress()}\n";
        }
        return shippingLabel;
    }
}