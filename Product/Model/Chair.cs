using System;
public class Chair : IProduct
{
    public Guid Id { get ; set ; }
    public string Name { get ; set; }
    public string Description { get ; set; }
    public bool IsOrdered { get ; set; }
    public double Price { get ; set; }
    public double MaxWeight { get ; set; }  
    public string  Material { get; set; }

    public Chair(string name, string description, bool isOrdered, double price, double maxWeght, string material)
    {
        Id = Guid.NewGuid();
        Name= name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        MaxWeight = maxWeght;
        Material = material;
    }

    public Chair(Chair chair)
    {
        Id = chair.Id;
        Name = chair.Name;
        Description = chair.Description;
        IsOrdered = chair.IsOrdered;  
        Price = chair.Price;
        MaxWeight = chair.MaxWeight;
        Material = chair.Material;
    }
}
