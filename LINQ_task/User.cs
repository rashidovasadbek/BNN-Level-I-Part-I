using System;
public class User
{
    public  string EmailAddres { get; set; }
    public  string Password { get; set; }
    public bool IsEmailValied= false;
    public bool IsPhoneValid= false;

    public User(string emailAddress, string password)
    {
        EmailAddres = emailAddress;
        Password = password;


    }
}
