using System;
public interface IEvent
{
    int Id { get; set; }
    string Name { get; set; }
    TimeOnly Date { get; set; }
}

