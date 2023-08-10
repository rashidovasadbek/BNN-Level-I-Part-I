
public class Project
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; } 
    
    List<Task> tasks = new ();

    public Project(string title, string description)
    {
        
        Title = title;
        Description = description;
        tasks = new ();
    }
}
