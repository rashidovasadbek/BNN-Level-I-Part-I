
using System.Net.Mail;
using System.Net;

Console.WriteLine("Emailingizni kiriting:");
string email = Console.ReadLine();

Console.WriteLine("ismingizni kiriting:");
string username = Console.ReadLine();

EmailService emailService = new EmailService("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
emailService.SendEmail(email,username);


public class EmailService
{
    public string CredentialAddress { get; init;}
    public string CredentialPassword { get; init;}

    public EmailService(string credentialAddress,string credentialPassword)
    {
        CredentialAddress = credentialAddress;
        CredentialPassword = credentialPassword;

    }

    public void SendEmail(string receiverEmail,string username)
    {
        var mail = new MailMessage(CredentialAddress, receiverEmail);
        mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
        mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz".Replace("{{User}}",username);

        var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        smtpClient.Credentials = new NetworkCredential(CredentialAddress, CredentialPassword);
        smtpClient.EnableSsl = true;

        smtpClient.Send(mail);
    }

}