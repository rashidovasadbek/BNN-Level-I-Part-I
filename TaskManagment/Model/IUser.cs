using System;


public interface IUser
{
    void Add(User user);
    User AuthnticateUser(string login, string password);
}
