using System;
public class Laptop: IProduct
{
    public Guid Id { get ; set ; }
    public string Name { get ; set ; }
    public string Description { get ; set ; }
    public bool IsOrdered { get; set; }
    public double Price { get; set ; }
    public string CpuBrand { get; set; }
    public string CpuModel { get; set; }

    public Laptop(string name, string description, bool isOrdered, double price, string cpuBrand,string cpuModel)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IsOrdered = isOrdered;
        Price = price;
        CpuBrand = cpuBrand;
        CpuModel = cpuModel;
    }
    public Laptop(Laptop laptop)
    {
        Id = laptop.Id;
        Name = laptop.Name;
        Description = laptop.Description;
        IsOrdered = laptop.IsOrdered;
        Price = laptop.Price;
        CpuBrand = laptop.CpuBrand;
        CpuModel = laptop.CpuModel;
    }
}
