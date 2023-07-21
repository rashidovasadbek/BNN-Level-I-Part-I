using Microsoft.VisualBasic;

var eventName = new List<string>();
eventName.Add("WorldDay");
eventName.Add("World Interfaith Harmony Week");
eventName.Add("World Autism Awareness Day");
eventName.Add("World Tuberculosis Day");
eventName.Add("World Poetry Day [UNESCO]");

var  eventTime = new List<DateTime>();
eventTime.Add(new DateTime(2023, 8, 10, 10, 0,0));
eventTime.Add(new DateTime(2023, 9, 1, 12, 30, 0));
eventTime.Add(new DateTime(2023, 12, 15, 16, 0, 0));
eventTime.Add(new DateTime(2023, 11, 17, 8, 30, 0));
eventTime.Add(new DateTime(2023, 10, 5, 9, 0, 0));

var nation = new List<string>();
nation.Add("en");
nation.Add("ru");
nation.Add("uz");

var temp = "";
for  (int i = 0; i < eventName.Count -1; i++)
{
    for(int j = i + 1; j < eventName.Count; j++)
    {
        if (eventName[i].Length > eventName[j].Length)
        {
            temp = eventName[i];
            eventName[i] = eventName[j];
            eventName[j] = temp;
        }
    }
}

    Console.WriteLine(nation[0]);
    for(int j = 0; j < eventName.Count; j++)
    {
    Console.WriteLine(eventName[j] + " - " + eventTime[j].ToString("MM.dd.yyyy HH:mm tt"));
    }
    Console.WriteLine();

    Console.WriteLine(nation[1]);
    for (int j = 0; j < eventName.Count; j++)
    {
        Console.WriteLine(eventName[j] + " - " + eventTime[j].ToString("dd/MM/yyyy HH:mm"));
    }
    Console.WriteLine();

    Console.WriteLine(nation[2]);
    for (int j = 0; j < eventName.Count; j++)
    {
        Console.WriteLine(eventName[j] + " - " + eventTime[j].ToString("dd.MM.yyyy HH:mm"));
    }
    Console.WriteLine();

