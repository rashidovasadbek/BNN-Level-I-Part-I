
using System.Net.Security;

PasswordGenerate passwordGenerateA = new PasswordGenerate(8,true,true);
PasswordGenerate passwordGenerateB = new PasswordGenerate(8, true);
//Console.WriteLine(passwordGenerateA.Generate());
//Console.WriteLine(passwordGenerateB.Generate());
SecurePasswordGenerator securePasswordGenerator = new SecurePasswordGenerator(8,true,true);
//Console.WriteLine(securePasswordGenerator.GenerateA(true));
UniqePasswordGenerate uniqePasswordGenerate = new UniqePasswordGenerate(8, true,true);
//uniqePasswordGenerate.GenerateUniqePassword();
public class PasswordGenerate
{
    public int Length { get; set; }
    public bool HasLatters { get; set; }
    public bool HasDigits { get; set; }  
    public PasswordGenerate(int length, bool haslatters, bool hasDigits = false) 
    {
        Length = length;
        HasLatters = haslatters;
        HasDigits = hasDigits;
    }

    public string Generate()
    {
        string pssword = string.Empty;
        Random random = new Random();  
        
        string numbers = "123456789";
        string letters = "abcdefghijklmnopqrstuvwxyz";
        
        while (pssword.Length < Length)
        {
            if (HasLatters)
               pssword += letters[random.Next(letters.Length)];

            if (HasDigits)
               pssword += numbers[random.Next(numbers.Length)];
            

        }  
       return pssword;
    }
}

public class SecurePasswordGenerator : PasswordGenerate
{
    public bool HasSimbols {get; set;}
    public SecurePasswordGenerator(int length, bool haslatters, bool hasDigits = false)
        : base(length, haslatters, hasDigits)
    { 
    }

    public string GenerateA(bool hasSymbols)
    {
        string pssword = string.Empty;
        Random random = new Random();

        string numbers = "123456789";
        string letters = "abcdefghijklmnopqrstuvwxyz";
        string OtherSimvols = "!#$%&()*+-.^_`";

        while (pssword.Length < Length)
        {
            if (HasLatters)
                pssword += letters[random.Next(letters.Length)];

            if (HasDigits)
                pssword += numbers[random.Next(numbers.Length)];
            if (hasSymbols == true)
                pssword += OtherSimvols[random.Next(OtherSimvols.Length)];

        }
        return pssword;

     
    }

}

public class UniqePasswordGenerate : SecurePasswordGenerator
{
    public UniqePasswordGenerate(int length, bool haslatters, bool hasDigits = false) : 
        base(length, haslatters, hasDigits)
    {

    }

    public void GenerateUniqePassword()
    {

        List<string> passwordList = new List<string>();
        Random random = new Random();

        string numbers = "123456789";
        string letters = "abcdefghijklmnopqrstuvwxyz";

        int i = 0;
        while (passwordList.Count < Length - 1)
        {
            string lettrs = letters[random.Next(letters.Length)].ToString();
            string number = numbers[random.Next(numbers.Length)].ToString();
            
            if (HasLatters && !passwordList.Contains(lettrs))     
                    passwordList.Add(lettrs);
            if (HasDigits && !passwordList.Contains(number))        
                    passwordList.Add(number);         
            
            i++;
        }

        foreach (string item in passwordList)
        {
            Console.Write(item);
        }

    }
}