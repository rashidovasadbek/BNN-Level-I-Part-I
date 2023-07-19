
zzz:
Console.WriteLine("sonlar qatnashsinmi: y/n");
char choosenumber= char.Parse(Console.ReadLine());

Console.WriteLine("harflar qatnashsinmi: y/n");
char chooseletters = char.Parse(Console.ReadLine());

Console.WriteLine("boshqa simvollar qatnashsinmi: y/n");
char chooseOtherSimvols = char.Parse(Console.ReadLine());

Console.WriteLine("password uzunligi: ");
int lengthPassword = int.Parse(Console.ReadLine());

string randomstring = "";
string numberstring = "0123456789";
string upperAndLowerString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
string OtherSimvols = "!#$%&()*+-.^_`";

var stringChars = new char[lengthPassword];
Random random = new Random();

if (choosenumber == 'y')
{
    randomstring += numberstring;
}
else if (choosenumber == 'n')
{
    randomstring +="";
}
if(chooseletters == 'y')
{
    randomstring += upperAndLowerString;
}
else if (chooseletters == 'n')
{
    randomstring +="";
}
if (chooseOtherSimvols == 'y')
{
    randomstring += OtherSimvols;
}
else if (chooseOtherSimvols == 'n')
{
    randomstring += "";
}

for (int i = 0; i < stringChars.Length; i++)
{
    stringChars[i] = randomstring[random.Next(randomstring.Length)];
    Console.Write(stringChars[i]);
}
Console.WriteLine('\n');
goto zzz;


