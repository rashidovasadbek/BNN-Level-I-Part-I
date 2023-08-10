Console.WriteLine("FirstName:");
var firstName = Console.ReadLine();
Console.WriteLine("LastName:");
var lastName = Console.ReadLine();
Console.WriteLine("Age:");
var age = int.Parse(Console.ReadLine());

var user = new User();
user._fisrtName = firstName;
user._lastName = lastName;
user._age = age;
Console.WriteLine($"FirstName:{user._fisrtName}\nLastName:{user._lastName}\nAge:{user._age}");
public class User
{
    public string _fisrtName;
    public string _lastName;
    public int _age;
}
