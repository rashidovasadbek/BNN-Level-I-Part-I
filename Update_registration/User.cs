
public class User : IUser
{

    public string Name { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public static bool Active_user { get; set; }

    public User(string name, string lastName, string middlename, string email, string username, bool active_user)
    {
        Name = name;
        LastName = lastName;
        MiddleName = middlename;
        Email = email;
        UserName = username;
        Active_user = active_user;
    }

    // string methodini ovvride qilib  displayga bervorish
    public override string ToString()
    {
        return $"{Name} | {LastName} | {MiddleName} | {UserName} | {Active_user}";
    }
}
