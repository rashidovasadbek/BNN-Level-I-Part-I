
using System.Text.RegularExpressions;
var vaildEmail = new Email
{
    To = "asadbekrashidov@gmail.com",
    From = "begzodaliy@gmail.com",
    Subject = "ishgajoylashish",
    Content = "shucompaniyadaishlash"
};
//Console.WriteLine(vaildEmail);

var invaildEmail = new Email
{
    To = "asadbekrashidov@gmail.com",
    From = "begzodaliy@gmail...com",
    Subject = "ishgajoylashish1",
    Content = "shucompaniyadaishlash123"
};
Console.WriteLine(invaildEmail);
public class Email
{
    public string to;
    public string from;
    public string subject;
    public string content;
    
    public string To
    {
        get
        {
            return to;
        }
        set
        {
            if (Regex.IsMatch(value, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
                to = value;
            else
                throw new ArgumentException("FormatExsaption");
        }
    }
    public string From
    {
        get
        {
            return from;
        }
        set
        {
            if (Regex.IsMatch(value, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
                from = value;
            else throw new ArgumentException("FormatExsaption");
        }
    }
    public string Subject
    {
        get
        {
            return subject;
        }
        set
        {
            if (Regex.IsMatch(value, "^[a-zA-Z'-]+$"))
                subject = value;
            else throw new ArgumentException("FormatExsaption");
        }
    }
    public string Content
    {
        get
        {
            return content;
        }
        set
        {
            if (Regex.IsMatch(value, "^[a-zA-Z'-]+$"))
                content = value;
            else throw new ArgumentException("FormatExsaption");
        }
    }

    public override string ToString()
    {
        return $"to-{to}\nfrom-{from}\nsubject-{subject}\ncontent-{content}";
    }

}