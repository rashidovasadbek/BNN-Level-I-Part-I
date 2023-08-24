using System;
public class TaskService
{
    private List<Tasks> _tasks;

    public TaskService()
    {
        _tasks = new List<Tasks>();
    }

    public void AddTask(Tasks task)
    {
        _tasks.Add(task);
    }
    public void CompleteTask(Guid taskId)
    {
        var task = _tasks.FirstOrDefault(a => a.Id == taskId);
        if (task != null) 
           task.IsCompleted = true;          
    }
    public List<Tasks> GetTasks(Priorty priorty)
    {
        return _tasks.Where(task => task.Priority == priorty).ToList();
    }

    public List<Tasks> GetTaksList()
    {
        return _tasks;
    }
}
