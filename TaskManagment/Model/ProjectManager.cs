using System;

public class ProjectManager : User
{
    public ProjectManager(string username,string password) 
        : base(username,password, (int)UserRole.ProjectMananger)
    {

    }
}


