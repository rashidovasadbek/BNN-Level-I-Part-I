
using System.Net;
using System.Text.RegularExpressions;
Validator validator = new Validator();

Console.Write("Enter you fullname address : ");
var fullname = Console.ReadLine();
validator.IsVaildName(fullname);

Console.Write("Enter you email address : ");
var emailAddress = Console.ReadLine();
validator.IsValidPhoneNumber(emailAddress);


Console.Write("Enter you number address : ");
var number = Console.ReadLine();
validator.IsValidPhoneNumber(number);


public class Validator
{
    private Regex fullName = new Regex("^[a-zA-Z]+ [a-zA-Z]+$");
    private Regex emailAdress = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"); 
    private Regex number = new Regex("^\\+?\\d{1,3}?[-.\\s]?\\(?\\d{1,4}\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

    public void IsVaildName(string fullname)
    {
        Console.WriteLine(fullName.IsMatch(fullname));

    }

    public void IsValidEmailAddress(string emailAddress)
    {
    
        Console.WriteLine(emailAdress.IsMatch(emailAddress));
    }

    public void IsValidPhoneNumber(string Number) 
    {
       
        Console.WriteLine(number.IsMatch(Number));
    }
}