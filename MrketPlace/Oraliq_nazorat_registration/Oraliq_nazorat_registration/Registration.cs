
using System.ComponentModel.Design;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Registration 
{ 
    private List<User> users = new List<User>();
    public bool CheckName(string name, string lastname, string middlename)
    {
        if(!Regex.IsMatch(name, "^[a-zA-Z'-]+$"))
            return false;
        if(!Regex.IsMatch(lastname, "^[a-zA-Z'-]+$"))
            return false;
        if(!Regex.IsMatch(middlename, "^[a-zA-Z'-]+$"))
            return false;
        return true;
    }

    public bool CheckEmailAddress(string emailaddress)
    {
        if(!Regex.IsMatch(emailaddress, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
            return false;
        return true;
    }

    public string GenerateUserName()
    {
        string update = "";
        Random rnd = new Random();
        foreach (User user in users)
        {
            update = $"{user.Name.ToLower()}{user.LastName.ToLower()}{rnd.Next(1, 1000)}";
        }
        return update;
    }

    private bool Add(string name,string lastname, string middlename,string emailaddress,string username = "")
    {
        bool check = false;
        if ( string.IsNullOrEmpty(name) && !CheckName(name, lastname, middlename))
        {
            Console.WriteLine("invalid name");
            return false;
        }
        if (string.IsNullOrEmpty(lastname) && !CheckName(lastname, middlename, name))
        {
            Console.WriteLine("invalid lastname");
            return false;
        }
        if (string.IsNullOrEmpty(middlename) && !CheckName(middlename, lastname, name))
        {
            Console.WriteLine("invalid middlename");
            return false;
        }
        if (string.IsNullOrEmpty(emailaddress) && !CheckEmailAddress(emailaddress))
        {
            Console.WriteLine("hii");
            Console.WriteLine("invalid emailaddress");
            return false;
        }
        if (Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
        {
            foreach (var item in users)
            {
                if (item.UserName == username)
                    username = GenerateUserName();
                break;
            }
        }

        users.Add(new User(name, lastname, middlename, emailaddress, username, false));
          check = true;
        return check;
    }

    public void Registor(string name, string lastname, string middlename, string email, string username = "")
    {
        var user = Add(name, lastname, middlename, email, username);
        if (user is true)
            SendEmail(email, username);
        var sendemail = SendEmail(email, username);
        if (sendemail is true)
            User.Active_user = true;
    }


    public bool SendEmail(string receiverAddress, string username)
    {
        try
        {
            var mail = new MailMessage("asadbekrashidov000@gmail.com", receiverAddress);
            mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
            mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz".Replace("{{User}}", username);

            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("@sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
            return true;
        }catch (Exception e) 
        {
            return false;
        }
    }
    public void Display()
    {
       foreach(var item in users)
            Console.WriteLine(item);
    }
}

