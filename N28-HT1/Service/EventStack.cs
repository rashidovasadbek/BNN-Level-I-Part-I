using System;
public class EventStack<T> where T : IEvent
{ 
    List<T> events = new List<T>();

    public void Push(T eventt)
    {
        try
        {
            if(events.Count == 0 || eventt.Date < events[events.Count - 1].Date)
            {
                events.Add(eventt);
            }
        }catch (Exception ex)
        {
            throw new Exception("Event must happen after the events in the stack");
        }
    }
    public T Peek()
    {
        return events[events.Count - 1];
    }
    public T Pop()
    {
        T temp = events[events.Count - 1];
        events.RemoveAt(events.Count - 1);
        return temp;
        
    }
}

