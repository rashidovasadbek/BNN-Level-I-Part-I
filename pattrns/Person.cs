

public class Person
{
    public string Name { get; set; }
    public byte Age { get; set; }
    public bool IsMarried;

    public Person(string name, byte age,bool ismarried = false)
    {
        Name = name;
        Age = age;
        IsMarried = ismarried;
    }
    public void Display(Person person)
    {
        Console.WriteLine($"{person.Name}\n{person.Age}\n{person.IsMarried}");
    }
}