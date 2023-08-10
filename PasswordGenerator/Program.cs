
Console.WriteLine("yes/no");
Console.WriteLine("Attend numbers:");
var hasDigts = Console.ReadLine();
Console.WriteLine("Attend letters:");
var hasLatters = Console.ReadLine();
Console.WriteLine("Attend symbols:");
var hasSybols = Console.ReadLine();
Console.WriteLine("Length:");
var length = int.Parse(Console.ReadLine());

PasswordGenerator passwordGenerator = new PasswordGenerator();
Console.WriteLine(passwordGenerator.Generate(hasDigts, hasLatters,hasSybols,length));
public class PasswordGenerator
{
    public string Generate(string hasDigits, string hasLatters, string hasSymbols, int length)
    {
        var generatestr = "";
        if(hasDigits == "yes")
        {
           for(int index = 48; index < 58; index++)
            {
                generatestr += (char)index;
            }
           
        }
        if(hasLatters == "yes")
        {
            for(var index = 65; index < 122; index++)
            {
                if(index  >= 65 && index <= 90 || index >= 97 && index <= 122)
                {
                    generatestr += (char)index;
                }
            }
        }
        if(hasSymbols == "yes")
        {
            for(var index = 33; index <= 47; index++)
            {
                generatestr += (char)index;
            }
        }
        Random random = new Random();
        string uniqepassword = "";
          
        for (var index = 1; index < length; index++)
        {
            if (uniqepassword.Contains(uniqepassword[index]))
            {
               string rnindex=random.Next(generatestr[generatestr.Length - 1]).ToString();
               uniqepassword+=generatestr[int.Parse(rnindex)];
            }
        }
        return uniqepassword;
    }

}