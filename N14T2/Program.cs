

Planner plannerA = new Planner();
plannerA.Add("Tug'ilgan kun", new TimeOnly(15, 0));
plannerA.Add("Toy", new TimeOnly(12, 0));
plannerA.Add("choyhona", new TimeOnly(20, 0));
plannerA.Add("meeting", new TimeOnly(20, 0));
plannerA.Display();


UltimatePlanner plannerB = new UltimatePlanner();
plannerB.Add("Tug'ilgan kun", new TimeOnly(15, 0));
plannerB.Add("Toy", new TimeOnly(12, 0));
plannerB.Add("choyhona", new TimeOnly(20, 0));
plannerB.Add("meeting", new TimeOnly(20, 0));
plannerB.Add("mitingA", new DateOnly(2023, 8, 1));
plannerB.Add("mitingB", new DateOnly(2023, 9, 3));
plannerB.Add("mitingC", new DateOnly(2023, 4, 2));
plannerB.Display();


public class Planner
{
    public Dictionary<string, TimeOnly> events = new Dictionary<string, TimeOnly>();
    public Dictionary<string, DateOnly> eventDate = new Dictionary<string, DateOnly>();

    public virtual void Add(string name, TimeOnly eventTime)
    {
        events[name] = eventTime;
    }

    public virtual void Display()
    {
        foreach (var item in events)
        {
            Console.WriteLine(item);
        }
    }
}

public class UltimatePlanner : Planner
{
    public override void Add(string name, TimeOnly eventTime)
    {
        var hasConflict = false;
        foreach (var item in events)
        {
           if(item.Value.Hour == eventTime.Hour)
            {
                hasConflict = true;
                Console.WriteLine("You have conflict in daily plan");break;
            }
        }

        if (!hasConflict)
            events[name] = eventTime;
    }

    public void Add(string name, DateOnly eventTime)
    {
        eventDate[name] = eventTime;
    }

    public override void Display()
    {
        foreach (var item in eventDate)
        {
            Console.WriteLine(item);
        }

        base.Display();
    }
}