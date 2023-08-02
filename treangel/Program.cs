

Treanger treangle = new Treanger(0,0,0);
Console.WriteLine($"Yuzi = {treangle.Arg} Peremetr = {treangle.Perimetr}");
public class Treanger
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Z { get; private set; }

    public Treanger(double x, double y, double z) 
    {
        if (!isValidArg(x, y, z))
            throw new ArgumentException("Uchburchak yasab bo'midi");
        
        X = x;
        Y = y;
        Z = z;
    }

    public double Perimetr { get => X + Y + Z;}
    public double Arg 
    { 
        get 
        {
            var p = Perimetr / 2;
            return Math.Sqrt(p * (p - X) * (p - Y) * (p - Z));
        
        } 
    
    }

    private bool isValidArg(double x, double y, double z)
    {
        return x < y + z && y < x + z && z < x + y; 
    }

}