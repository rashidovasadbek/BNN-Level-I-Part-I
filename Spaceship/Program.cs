


Speceship speceship = new Speceship("Ali",345);


//Console.WriteLine(speceship.Name);
Console.WriteLine(speceship.Fuel);
Console.WriteLine(speceship.Speed);
Console.WriteLine(speceship.Speed = 141);
Console.WriteLine(speceship.Speed = 789);
Console.WriteLine(speceship.Trajectory = 23);
Console.WriteLine(speceship.Trajectory = 345);
Console.WriteLine(speceship.Trajectory = 24);
Console.WriteLine(speceship.Trajectory = 2676);
Console.WriteLine(speceship.Trajectory = 9546);
public class Speceship
{
    private string Name { get; init; }

    private readonly double _fuel;
    public double Fuel => _fuel;

    private int _speed;
    public int Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }

    private int trajectory;
    public int Trajectory
    {
        set
        {
            trajectory = value;
        }
    }

    public Speceship(string name, int speed)
    {
        Name = name;
        Speed = 567;
       _fuel = 34;
    }
}


