using System;

public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
    }
}
