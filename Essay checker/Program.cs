using System.Runtime.ConstrainedExecution;

int ball = 100;
string text = "Lorem ipsum dolor sit amet consectetur adipisicing elit.quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum.Numquam rem alias minima culpa iste distinctio.Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores!Repellat, dolorum!";

if (text.Length < 500)
{
    ball -= 5;
}

var wordscount = 0;
var words = text.Split(' ');
for  (int i = 0; i < words.Length; i++)
{
    for (int j = 1; j < words[i].Length ; j++)
    {
        bool check = words[i].Contains(words[j], StringComparison.OrdinalIgnoreCase);
        if (check)
            wordscount++;
    }
    if (words.Length / 5 < wordscount)
    {
        //Console.WriteLine(words[i]);
        ball -= 5;
        break;
    }
 
}

var wordsA = text.Split('.','!');
for (int i = 0; i < wordsA.Length - 1; i++)
{
    bool checkA = Char.IsLower(wordsA[i].ToString(),0);
    if (checkA)
    {
        //Console.WriteLine(wordsA[i][0]);
        ball -= 5;
    }
}

var wordsB = text.Split(' ');
bool checkB = false;
for (int i = 0;i < wordsB.Length; i++)
{
    for(int j = 0; j < wordsB[i].Length -1; j++)
    {
        //Console.Write(wordsB[i][j]);
        checkB = Char.IsUpper(wordsB[i],1);   
    }
    if (checkB)
    {
        ball -= 10;
    }
}

var wordsC = text.Split('.');
var countC = 1;
for(int i = 0; i < wordsC.Length; i++)
{
    for(var j = 0;j < wordsC[i].Length; j++)
    {
        if (wordsC[i][j] == ' ')
        {
            countC++;
        }
    } 
    if(countC  > 20)
    {
       /* Console.WriteLine(countC);
        Console.WriteLine(wordsC[i]);*/
        ball -= 20;  
    }
    countC = 0;
}

Console.WriteLine(ball);