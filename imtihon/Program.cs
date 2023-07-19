var student = new string[10];
student[0] = "Akbar";
student[1] = "Shodiyor";
student[2] = "Ahmad";
student[3] = "G'ayrat";
student[4] = "Toxir";
student[5] = "Asila";
student[6] = "Boxodir";
student[7] = "Malika";
student[8] = "Robiya";
student[9] = "Dilmurod";

var ball = new int[10];
ball[0] = 70;
ball[1] = 80;
ball[2] = 65;
ball[3] = 100;
ball[4] = 90;
ball[5] = 50;
ball[6] = 55;
ball[7] = 80;
ball[8] = 75;
ball[9] = 60;


int tempA = ball[0];
for(int i = 0; i < ball.Length - 1; i++)
{
    for(int j = i + 1; j < ball.Length; j++)
    {
        if (ball[i] < ball[j])
        {
            tempA = ball[i];
            ball[i] = ball[j];
            ball[j] = tempA;
        }
    }
}

int sum = 0;
for(int i = 0;i < ball.Length; i++)
{
    sum += ball[i];
}
Console.WriteLine("Eng baland ball");
Console.WriteLine(ball[0]);
Console.WriteLine("O'rtacha ball:");
Console.WriteLine(sum/ball.Count());
Console.WriteLine("Eng past ball");
Console.WriteLine(ball[ball.Length - 1]);
Console.WriteLine();
int count80 = 0;
int count90 = 0;
for(var i = 0; i < ball.Length; i++)
{
    if (ball[i] > 80)
    {
        
        count80++;
    }
    if (ball[i] > 90)
    {
        
        count90++;
    }
}
Console.WriteLine("80 dan baland olgan studentlar soni");
Console.WriteLine(count80+" ta");
Console.WriteLine("90 dan baland olgan studentlar soni");
Console.WriteLine(count90+" ta");
Console.WriteLine();
int tempB = ball[0];
var tempC = student[0];

for (int i = 0; i < student.Length - 1; i++)
{
    for (int j = i + 1; j < student.Length; j++)
    {
        if (ball[i] < ball[j])
        {
            tempB = ball[i];
            ball[i] = ball[j];
            ball[j] = tempB;

            tempC = student[i];
            student[i] = student[j];
            student[j] = tempC;
        }
    }
}

for(int i = 0;i < student.Length; i++)
{
    if (ball[i] >= 90)
    {
        Console.WriteLine(student[i] + "-Top");
    }
    else if (ball[i] >= 70 )
    {
        Console.WriteLine(student[i] + "-Good");
    }
    else if (ball[i] < 70)
    {
        Console.WriteLine(student[i] + "-Fail");
    }
}