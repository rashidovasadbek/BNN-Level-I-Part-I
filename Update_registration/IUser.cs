using System;
public interface IUser
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public static bool Active_user { get; set; }


}

