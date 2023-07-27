
var optengier = new OptimizedGameEngine();
optengier.Display();

public class Hero
{
    public Hero( string name) 
    {
        Id = Guid.NewGuid();
        Name = name; 
    }
    public Guid Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id-{Id} Name-{Name}";
    }
}


public class GameEngine
{
    public List<Hero> HeroList  = new List<Hero>();

    public GameEngine()
    {
        HeroList.Add(new Hero("Yurnero"));
        HeroList.Add(new Hero("Sven"));
        HeroList.Add(new Hero("Tiny"));

    }

    public void Display()
    {
        foreach (var hero in HeroList)
            Console.WriteLine(hero.ToString());
    }
}

public class OptimizedGameEngine : GameEngine 
{ 
    public OptimizedGameEngine()
    {
        HeroList.Add(new Hero("Invoker"));
        HeroList.Add(new Hero("Lina"));
        HeroList.Add(new Hero("Medusa"));


    }
}
