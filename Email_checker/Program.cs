using System.Security.Cryptography;

Console.WriteLine("Emailingizni kiriting:");
string email = Console.ReadLine();
bool  check = false;
string temp = "";
string lowerlater = "";
for (int j = 0; j < email.Length; j++)
{
    if ((email[j] >= 'A' && email[j] <= 'Z') || (email[j] >= 'a' && email[j] <= 'z') || email[j] == '.' || email[j] == '@')
    {
        lowerlater += email[j].ToString().Replace(email[j], char.ToLower(email[j]));
    }
}


for  (int i = 0;i < lowerlater.Length; i++)
{
    
    if ((char)(lowerlater[i]) > 96 && (char)(lowerlater[i]) < 123) 
    {
            check = true;
    }
    else if ((char)(lowerlater[i]) > 47 && (char)(lowerlater[i]) < 59)
    {
         check = true;
    }
    else if((char)(lowerlater[i]) == 64) 
    {
        check = true;
    }
    else if((char)(lowerlater[i]) == 46)
    {
         check = true;
    }
    else
    {
        check = false;
        temp += email[i];
        break;
    }
}
Console.WriteLine(lowerlater);
if (check == true)
    Console.WriteLine("Good");
else 
    Console.WriteLine(temp);

