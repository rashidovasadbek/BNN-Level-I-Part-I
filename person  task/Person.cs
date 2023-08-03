using System.Xml.Linq;

public class Person
{
    private string _name;
    private int _age;
    private string _city;
    private readonly string _nationality;

    public Person()
    {
    }

    public Person(string name, int age, string city, string nationaly)
    {
        _name = name;
        _age = age;
        _city = city;
        _nationality = nationaly;
    }

    public Person(Person person)
    {
        _name = person._name;
        _age = person._age;
        _city = person._city;
        _nationality = person._nationality;
    }
    static Person()
    {
        Console.WriteLine("static konstructor ishladi");
    }

    public override string ToString()
    {
        return $"name:{_name}\nage:{_age}\ncity{_city}\nnationality:{_nationality}";
    }
}
