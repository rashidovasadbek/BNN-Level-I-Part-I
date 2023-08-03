
public class User
{
    public static string _name;
    public static int _age;
    public static string _city;
    public static string _nationality;

    private User(string name, int age, string city, string nationaly)
    {
        _name = "Bekzod";
        _age = 18;
        _city = "USA";
        _nationality = "English";
    }

    public static void Show()
    {
        Console.WriteLine($"name:{_name}\nage:{_age}\ncity{_city}\nnationality:{_nationality}");
    }
}

