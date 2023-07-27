

using static System.Net.Mime.MediaTypeNames;
var eventmanaget = new EventManager();

eventmanaget.Add("meetingA", new TimeOnly(12, 30));
eventmanaget.Add("meetingB", new TimeOnly(10, 0));
eventmanaget.Add("meetingC", new TimeOnly(15, 30));
eventmanaget.Add("meetingD", new TimeOnly(18, 0));
eventmanaget.Add("meetingF", new TimeOnly(7, 30));


eventmanaget.Add("tug'ulgan kun", new DateOnly(2023, 7, 29));
eventmanaget.Add("to'y", new DateOnly(2023, 7, 11));
eventmanaget.Add("mazar", new DateOnly(2023, 7, 27));
eventmanaget.Add("osh", new DateOnly(2023, 7, 30));
eventmanaget.Add("banket", new DateOnly(2023, 3, 14));
eventmanaget.Add("yubley", new DateOnly(2023, 5, 18));

eventmanaget.Display();
public class EventManager
{

    Dictionary<string, DateOnly> CalendarEvents = new Dictionary<string, DateOnly>();
    Dictionary<string,TimeOnly> DailyEvents = new Dictionary<string,TimeOnly>();

    public void Add(string name,DateOnly dateTime)
    {
        CalendarEvents.Add(name, dateTime);
    }
    public void Add(string name,TimeOnly timeOnly)
    {
        DailyEvents.Add(name, timeOnly);
    }

    public void Display() 
    {
        foreach (var item in DailyEvents)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }

        var nowTime = DateTime.Now;
        var now = new DateOnly(nowTime.Year, nowTime.Month, nowTime.Day);

        foreach (var item in CalendarEvents) 
        {
            if(item.Value == now.AddDays(1) 
                || item.Value == now.AddDays(2)
                || item.Value == now.AddDays(3))

                Console.WriteLine($"{item.Key} {item.Value}");
        }

       
    }
}