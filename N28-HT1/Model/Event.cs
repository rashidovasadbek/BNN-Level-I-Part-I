using System;
public class Event : IEvent 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TimeOnly Date { get; set; }

    public Event(int id, string name, TimeOnly dateTime)
    {
        Id = id;
        Name = name;
        Date = dateTime;
    }

    public override string ToString()
    {
        return $"ID:{Id}\nName:{Name}\nDate:{Date}\n";
    }
}
