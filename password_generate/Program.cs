bool choose;
Console.WriteLine("sonlar qatnashsinmi: y/n");
char choosenumber= char.Parse(Console.ReadLine());

Console.WriteLine("harflar qatnashsinmi: y/n");
char chooseletters = char.Parse(Console.ReadLine());

Console.WriteLine("boshqa simvollar qatnashsinmi: y/n");
char chooseOtherSimvols = char.Parse(Console.ReadLine());

Console.WriteLine("password uzunligi: ");
int lengthPassword = int.Parse(Console.ReadLine());

Random random = new Random();
string str = "";
if (choosenumber == 'y')
{
    choose = true;
}
else if (choosenumber == 'n')
{
    choose = false;
}
else
    Console.WriteLine("invalid choose");
 
for (int i  = 0; i < lengthPassword; i++)
{
    if (choosenumber == 'y')
    {
        str += (random.Next(1, 10).ToString());
    }

    if (chooseletters == 'y')
    {
        str += (char)(random.Next(65, 91));
    }

    if (lengthPassword == 'y')
    {
        str += (char)(random.Next(33, 47));
    }
   
    
}
Console.WriteLine(str.Count());