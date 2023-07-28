
using System.ComponentModel;
var sparrow = new Sparrow();
sparrow.MakeSound();
sparrow.Fly();

var tigir = new Tigir();
tigir.MakeSound();
tigir.Run();

var greateWhiteShark = new GreatWhiteShark();
greateWhiteShark.MakeSound();
greateWhiteShark.Swwim();

public class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}

public class Bird:Animal
{
    public void Fly()
    {
        Console.WriteLine("Fly");
    }
}

public class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Run");
    }
}

public class Fish :Animal
{
    public void Swwim()
    {
        Console.WriteLine("Swim");
    }
}

public class Sparrow : Bird
{

}

public class Tigir : Mammal
{
}

public class GreatWhiteShark : Fish
{

}