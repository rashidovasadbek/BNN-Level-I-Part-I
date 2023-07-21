using System.Numerics;

var listplans = new List<string>();
listplans.Add("Ahmad");
listplans.Add("Toshmad");
listplans.Add("G'ayrat");
listplans.Add("Bob");


const string CompanyName = "The Travel Guru";
const string NameToken = "{{Name}}";
const string CompanyNameToken = "{{CompanyName}}";
const string TicketDateToken = "{{TicketDate}}";


var timePlane = new Dictionary< TimeOnly, int>();
timePlane.Add(new TimeOnly(7, 0),4);
timePlane.Add(new TimeOnly(8, 0), 15);
timePlane.Add(new TimeOnly(10, 0), 3);


var massages = new Dictionary<string,string>();
massages.Add("UnderAge", "Uzr hurmatli {{Name}} siz loyhadan foydalanishga kichkinasiz");
massages.Add("GoldenAger", "Uzr hurmatli {{Name}} siz loha yoshlar uchun mo'jallangan\"");


var emails =  new LinkedList<string>();
emails.AddFirst("Hello {{Name}}. Welcome to onboard. {{CompanyName}} Team.");
emails.AddLast("Your data is being processed and we will inform updates for you as soon as possible. {{CompanyName}} Team");
emails.AddLast("Congratulations! Your flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team.");


// ro'hatdan o'tish jarayoni
Console.WriteLine("ismingizni kiriting:");
var name = Console.ReadLine();
for (int j = 0; j < name.Length; j++) {
    if (!char.IsDigit(name[j]) || string.IsNullOrWhiteSpace(name))
    {
        listplans.Add(name);
    }
    else
    {
        Console.WriteLine("Invalid name");
        Console.WriteLine("Try again:");
    }

}

Console.WriteLine("Yoshingizni kiriting:");
var age= int.Parse(Console.ReadLine());
if(age < 18)
{
    Console.WriteLine(massages["UnderAge"].Replace(NameToken,name));
    return;
}
else if(age > 90)
{
    Console.WriteLine(massages["GoldenAger"].Replace(NameToken,name));
    return;
}

// biletlarni olish jarayoni

TimeOnly savefilighttime = new();
foreach(var item in timePlane)
{
    if(item.Value >= listplans.Count())
    {
        savefilighttime = item.Key;
        break;
    }
}

//emailllar yuborish
foreach(var email in emails)
{
    Console.WriteLine(email
        .Replace(CompanyNameToken,CompanyName)
        .Replace(NameToken,name)
        .Replace(TicketDateToken,savefilighttime.ToString("")));
}
    

