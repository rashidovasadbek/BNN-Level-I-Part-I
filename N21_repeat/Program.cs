





using System.Net;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;

var emailService = new EmailService();
var smsService = new SmsService();
var registrationService = new RegistrationService();

var accountService = new AccountService(smsService,registrationService);
accountService.Create("asadbekrashidov000@gmail.com", "12345");
public interface INotificationService
{
    bool Send(User user,string subject,string body);
}
public interface IRegistrationService
{
    //User Register(string emailAddress,string password);
}
public interface IAccountService
{
    bool Create(string emailAddress,string password);
}
public interface IEmailService
{
    IEnumerable<object> SmtpClientInstance { get; set; }
}

public class EmailService : INotificationService, IEmailService
{
    public SmtpClient SmtpClientInstance { get; set; }
    IEnumerable<object> IEmailService.SmtpClientInstance { get; set; }

    public EmailService()
    {
        SmtpClientInstance = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        SmtpClientInstance.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        SmtpClientInstance.EnableSsl = true;
    }

    public bool Send(User user,string subject,string body)
    {
        var mail = new MailMessage("asadbekrashidov000@gmail.com", user.EmailAddress);
        mail.Subject = subject;
        mail.Body = body;

        SmtpClientInstance.Send(mail);
        return true;
    }

    public IEnumerable<Object> SearchForUser(string emailAddress)
    {
        throw new NotImplementedException();
    }
}

public class SmsService : INotificationService
{
    public bool Send(User user, string subject, string body)
    {
        throw new NotImplementedException ();
    }
}

public class RegistrationService : IRegistrationService
{
    List<User> users = new();    

    public User Register(string emailAddress, string password)
    {
        throw new NotImplementedException ();
    }
}

public class AccountService
{
    private readonly INotificationService _notificationService;
    private readonly IRegistrationService _registrationService;

    public AccountService(INotificationService notificationService, IRegistrationService registrationService)
    {
        _notificationService = notificationService;
        _registrationService = registrationService;
    }

    public bool Create(string emailAddress, string password)
    {
        //var newUser = _registrationService.Register(emailAddress, password);
        //if(newUser is not null)
        User newUser = new User()
        {
            EmailAddress = "asadbekrashidov000@gmail.com",
            Password = password
        };
        {
            return _notificationService.Send(newUser, "Welcome", "Welcome to our website");
        }
        return false;
    }
}

public class User
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }
}






/*public interface ITaskEvent
{
    string Name { get; set; }
    int proprty { get; set; }
}
public class TaskItem : ITaskEvent
{
    public  string Name { get; set; }
    public int proprty { get; set;}

    public void DoSomething()
    {

    }
}

public class EventItem : ITaskEvent
{
    public string Name { get; set; }
    public int proprty { get; set;}
    public DateTime dateTime { get; set; }
}
*/