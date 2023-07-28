

Animal animalA = new Bird();
Animal animalB = new Tigir();
Animal animalC = new Fish();
animalA.FunFact();
animalB.FunFact();
animalC.FunFact();
public class Animal
{
    public virtual void FunFact()
    {
        Console.WriteLine("ko'rish imkoniyati...");
    }
}
public class Bird:Animal 
{
    public override void FunFact()
    {
        Console.WriteLine("ucha olish imkoniyat...");
    }
}

public class Tigir : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("tez yugura olish imkoniyati...");
    }
}

public class Fish : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("tez suza olish imkoniyati...");
    }
}

