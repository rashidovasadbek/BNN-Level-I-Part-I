
using System.Threading.Tasks.Sources;

var sleepday = new DateOnly[5];
sleepday[0] = new DateOnly(2023, 8, 3);
sleepday[1] = new DateOnly(2023, 8, 5);
sleepday[2] = new DateOnly(2023,8,2);
sleepday[3] = new DateOnly(2023,8,4);
sleepday[4] = new DateOnly(2023,8,1);

var duration = new int[5];
duration[0] = 7;
duration[1] = 6;
duration[2] = 7;
duration[3] = 6;
duration[4] = 5;


var sleepBreakCount = new int[5];
sleepBreakCount[0] = 0;
sleepBreakCount[1] = 3;
sleepBreakCount[2] = 1;
sleepBreakCount[3] = 2;
sleepBreakCount[4] = 3;




for (int i = 0; i < sleepday.Length - 1; i++)
{
    
    DateOnly currentDate = sleepday[i];
    DateOnly nextDate = sleepday[i + 1];
   
    int currentduraction = duration[i];
    int nextduraction = duration[i + 1];

    int currnetsleepBreakCount = sleepBreakCount[i];
    int nextsleepBreakCount = sleepBreakCount[i + 1];
    
    if (currentDate < nextDate)
    {
        DateOnly temp = currentDate;
        currentDate = nextDate;
        nextDate = temp;
    }

    if(currentduraction > nextduraction)
    {
        int tempA = currentduraction;
        duration[i] = nextduraction;
        duration[i +1] = tempA;
    }

    if(currnetsleepBreakCount > nextsleepBreakCount)
    {
        int temp = currnetsleepBreakCount;
        sleepBreakCount[i] = nextsleepBreakCount;
        sleepBreakCount[i + 1] = temp;
    }
}

foreach(var item in sleepday)
{
    Console.WriteLine(item);
}

float PreviousDayMissingSleepHours = 0;
float score = 0f;
for (int index = 1; index <= 5; index++)
{
    if (duration[index - 1] < 8)
        PreviousDayMissingSleepHours = (8 - duration[index - 1]);

    score = (duration[index - 1] - sleepBreakCount[index - 1] / duration[index - 1]) / (8 + PreviousDayMissingSleepHours) * 10;

    Console.WriteLine($"{sleepday[index - 1]}- {duration[index - 1]} hours {score.ToString("F2")}-score");
}

