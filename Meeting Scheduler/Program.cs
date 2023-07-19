using System;
using System.Threading;

var startTime = new TimeOnly(8,0,0);
var EndTime = new TimeOnly(18, 0, 0);
var meeting = new TimeOnly[7];

meeting[0] = new TimeOnly(9, 30, 0);
meeting[1] = new TimeOnly(7, 0, 9);
meeting[2] = new TimeOnly(12,35,0);
meeting[3] = new TimeOnly(20, 0, 0);
meeting[4] = new TimeOnly(15, 25, 0);
meeting[5] = new TimeOnly(16, 0, 0);
meeting[6] = new TimeOnly(19,0,0);

var whilemeeting = new TimeSpan[7];
whilemeeting[0] = TimeSpan.FromMinutes(20);
whilemeeting[1] = TimeSpan.FromMinutes(30);
whilemeeting[2] = TimeSpan.FromMinutes(25);
whilemeeting[3] = TimeSpan.FromMinutes(45);
whilemeeting[4] = TimeSpan.FromMinutes(15);
whilemeeting[5] = TimeSpan.FromMinutes(13);
whilemeeting[6] = TimeSpan.FromMinutes(40);

Console.WriteLine("Ish vaqtiga to'g'ri kelmaydigan meetinglar");
for(int i = 0; i < 7; i++)
{
    if (meeting[i].Hour > EndTime.Hour 
        || meeting[i].Hour < startTime.Hour 
        || EndTime.Hour + startTime.Hour > EndTime.Hour)
    {
        Console.WriteLine(meeting[i]);
    }
}

Console.WriteLine("davomiyligi 30 daqiqadan oshadigan meetinglar");

for (int i = 0; i < 7; i++)
{
    if (whilemeeting[i] > TimeSpan.FromMinutes(30))
    {
        Console.WriteLine(whilemeeting[i]);
    }
}

Console.WriteLine("umumiy mitinglar yig'indisi ");

TimeSpan sumTillNowTimeSpan = TimeSpan.Zero;
foreach (TimeSpan timeSpan in whilemeeting)
{
    sumTillNowTimeSpan += timeSpan;
}
Console.WriteLine(sumTillNowTimeSpan);

Console.WriteLine("mitinglar orasida eng ko'p va eng kam vaqtlar:");

var temp = whilemeeting[0];
for(int i =0; i < 6; i++)
{
    for(int j = i + 1; j < 7; j++)
    {
        if (whilemeeting[i] > whilemeeting[j])
        {
            temp = whilemeeting[i];
            whilemeeting[i] = whilemeeting[j];
            whilemeeting[j] = temp;
        }
    }
}

Console.WriteLine("Max:" + whilemeeting[whilemeeting.Length - 1].ToString());
Console.WriteLine("Min:"+whilemeeting[0].ToString());

