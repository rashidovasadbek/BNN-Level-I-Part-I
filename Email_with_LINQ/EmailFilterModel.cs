using System;

public class EmailFilterModel 
{ 
    public string? ReceiverAddress { get; set; }
    public string? SenderAddress { get; set; }
    
    public DateTime? Date;
    public int PageSize { get; set; }   
    public int PageToken { get; set; }

    public EmailFilterModel(string? receiverAddres,string? senderAddres,DateTime? date, int pageSize, int pageToken)
    {
        ReceiverAddress = receiverAddres;
        SenderAddress = senderAddres;
        Date = date;
        PageSize = pageSize;
        PageToken = pageToken;
    }
}

