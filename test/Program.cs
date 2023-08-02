
using System.Security.Principal;

EmailTemplateService templateService = new EmailTemplateService();
templateService.Add("Account Registration", "Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi");
templateService.Add("Account Blocked", "Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi");
Console.WriteLine("ismingizni kiriting:");
string name = Console.ReadLine();
Console.WriteLine(templateService.GetRegistrationTemplate(name));
Console.WriteLine(templateService.GetAccountBlockedTemplate(name));


public class EmailTemplates
{
    public string Subject { get; set; }
    public string Content { get; set; }

    public EmailTemplates(string subject,string content)
    {
        Subject = subject;
        Content = content;
    }
}

public static class  MessageConstants
{
    public static string UserNameToken = "{{User}}";
}
public class EmailTemplateService
{
    private List<EmailTemplates> emailTemplates = new();

    public void Add(string subject, string content)
    {
        emailTemplates.Add(new EmailTemplates(subject, content));
    }

    public string GetRegistrationTemplate(string username)
    {
        return username.Replace(MessageConstants.UserNameToken, username);
    }

    public string GetAccountBlockedTemplate(string username)
    {
        return username.Replace(MessageConstants.UserNameToken, );
    }
}