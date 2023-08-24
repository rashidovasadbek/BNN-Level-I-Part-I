using System;
public class Meeting
{

    public string Name { get; set; }
    public TimeSpan Duraction { get; set; }

    public Meeting(string name, TimeSpan duraction)
    {
        Name = name;
        Duraction = duraction;
    }

    public static TimeSpan operator +(TimeSpan time,Meeting meeting)
    {
        
        return meeting.Duraction + time;
    }

    public override string ToString()
    {
        return $"{Name} - {Duraction}";
    }

}
