

public class Task 
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }  
    public Developer Assignee { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string title, string description, DateTime dateTime)
    {
        Title = title;
        Description = description;
        Deadline = dateTime;
   
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }
}

