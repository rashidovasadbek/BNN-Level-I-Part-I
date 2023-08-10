using System.Reflection.Metadata;

User developer = new User()
{
    Id = Guid.NewGuid(),
    Username = "Admin",
    Password = "password",

};

Console.WriteLine("TaskManagment".PadLeft(35));
Console.Write("Login:");
var login  = Console.ReadLine();
Console.Write("Parol:");
var parol = Console.ReadLine();

/*bool SignIn(string login, string parol, Developer developer)
{

}*/

