using System;


public class Monitor : IProduct
{
    public Guid Id { get; set;}
    public string Name { get; set;}
    public string Description { get; set;}
    public bool IsOrdered { get; set;}
    public double Price { get; set;}
    public double DisplaySize { get; set;}   
    public double RefreshRate { get; set;}
    public Monitor(string name, string description, bool isOrdered,double price, double displaySize,double refreshrate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        DisplaySize = displaySize;
        RefreshRate = refreshrate;
    }

    public Monitor(Monitor monitor)
    {
        Id = monitor.Id;
        Name = monitor.Name;
        Description = monitor.Description;
        IsOrdered = monitor.IsOrdered;
        Price = monitor.Price;
        DisplaySize = monitor.DisplaySize;
    }
}
