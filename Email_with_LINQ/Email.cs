using System;

public class Email
{
    public string ReceiverAddress { get; set; }
    public string SenderAddress { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
   
    public DateTime Date;
    public bool IsClassified { get; set; }

    public Email(string receiverAddres, string senderAddres,string subject,string body, DateTime date, bool isClassified)
    {
        ReceiverAddress = receiverAddres;
        SenderAddress = senderAddres;
        Subject = subject;
        Body = body;
        Date = date;
        IsClassified = isClassified;
    }
    public Email()
    {
        
    }

}

