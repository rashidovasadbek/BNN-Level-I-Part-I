using System;

public class RegistrationServise 
{
    private List<User> _users = new List<User>();
    public bool Register(string emailAddres, string password)
    {
        var newUser = new User(emailAddres, password);

        if (_users.Any(user => user.EmailAddres == emailAddres))
        {
            Console.WriteLine("Bu email address allaqachon bor");
            return false;
        }
            _users.Add(newUser);
         return true;
       
    }

    public bool Login(string username, string password)
    {
        var isvalied = _users.FirstOrDefault(user => user.IsEmailValied && user.IsPhoneValid);
        if (isvalied.IsPhoneValid && isvalied.IsEmailValied)
        {
            Console.WriteLine("Sorry, you haven't verified your email address / phone number");
            return false;
        }
        return true;
    }
}

