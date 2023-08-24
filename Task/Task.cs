using System;
public class Tasks
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public Priorty Priority;
    public DateTime DeadLIne { get; set; }
    public  bool IsCompleted;
    public DateTime CreateDate { get; set; }

    public Tasks(string description, Priorty priorty, DateTime dateline)
    {
        Id = Guid.NewGuid();
        Description = description;
        Priority = priorty;
        DeadLIne = dateline;
        IsCompleted = false;
        //DeadLIne = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Id:{Id}\n" +
            $"Description:{Description}\n" +
            $"Priority:{Priority}\n" +
            $"DeadLIne:{DeadLIne}\n" +
            $"IsCompleted:{IsCompleted}\n" +
            $"DeadLIne{DeadLIne}";
    }
}
