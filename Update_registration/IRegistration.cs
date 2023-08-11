
using System;

public interface IRegistration
{
    public bool CheckName(string name, string lastname, string middlename);
    public bool CheckEmailAddress(string emailaddress);
    public bool Add(string name, string lastname, string middlename, string emailaddress, string username = "")
    {
        return false;
    }
    public void Registor(string name, string lastname, string middlename, string email, string username = "");
    public bool SendEmail(string receiverAddress, string username);
    public void Display();
}
