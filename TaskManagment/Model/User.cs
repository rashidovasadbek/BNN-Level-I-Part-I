public enum UserRole
{
    ProjectMananger,
    Developer
}

public class User : IUser
{
    public Guid Id { get; set; }
    public string login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int RoleId { get; set; } 

    public User(string username,string password, int roleId)
    {
    
        login = username;
        Password = password;
        RoleId = roleId;

    }

    public void Add(User user)
    {
        throw new NotImplementedException();
    }

    public User AuthnticateUser(string login, string password)
    {
        throw new NotImplementedException();
    }
}


