using System;
public class product
{
    public string Name { get; set; }
    public int Stars { get; set; }
    public int Inventory { get; set; }

    public product(string name,int stars, int inventory)
    {
        Name = name;
        Stars = stars;
        Inventory = inventory;
    }
}
