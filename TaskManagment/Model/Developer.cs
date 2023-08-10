using System;

public class Developer : User
{
    List<Task> AssignedTasks = new List<Task>();
    public Developer(string username,string password) 
        : base(username,password, (int)UserRole.Developer)
    {
        AssignedTasks = new List<Task>();
    }

}

