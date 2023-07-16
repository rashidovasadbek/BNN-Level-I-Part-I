Console.Write("ism sharifingizni kiriting:");
var name = Console.ReadLine();
Random random = new Random();

var strgenerate = "";
var strsimvols = new string[] {"@","#","$","-","_"};

int index = random.Next(strsimvols.Length - 1);
strgenerate+=strsimvols[index];

var usernamebaza = new string[]
{ "Alisher-Kasmanaft","G'ayrat-bob","QodirAli123","Mamarayimlolikk","Nasiba426","Natasha990","Odil-uchar","Jumagul-maysa","Toxir-tank","Ali325"}; 

for  (int i = 0; i < usernamebaza.Length; i++)
{
    if(name != usernamebaza[i])
    {
        for (int j = 0;j < 3; j++)
        {
           strgenerate += random.Next(1,9).ToString();
        }
        break;
    }
    else
    {
        Console.WriteLine(usernamebaza[i] + strsimvols[index]);break;
    }
}

 Console.WriteLine(name+strgenerate);