


public class Shape
{
    public virtual void CalculateArea(double x, double y, double z)
    {
       
    }
}
 
public class Triangle:Shape
{
    public override void CalculateArea(double a, double b, double c)
    {
        var p = a + b + c;
        Console.WriteLine(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }
}

public class Rectangle : Shape
{
    public override void CalculateArea(double a, double b,double c)
    {
        Console.WriteLine();
    }
}

public class Circle : Shape
{ 
    public override void CalculateArea(double a, double b, double c) 
    { 
       Console.WriteLine();
    }
}

