using System.Text.RegularExpressions;

var email = new List<string>();
email.Add("john.doe@example.com");
email.Add("john.doe+tag@example.com");
email.Add("john.doe@example…com");
email.Add("john.doe@example.travel");
email.Add("john.doe@.example.com");
var emailAddressPattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
foreach (var emailAddress in email)
    Console.WriteLine(Regex.IsMatch(emailAddress,emailAddressPattern));