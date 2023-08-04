public class ChatMassage
{
    public Guid Id { get; set; }
    public DateTime SentTime { get; set; }
    public DateTime EditTime { get; set; }
    public string Content { get; set; }

    public ChatMassage( string content)
    {
        Id = Guid.NewGuid();
        SentTime = DateTime.Now;
        EditTime = DateTime.Now;
        Content = content;
    }
    public ChatMassage(ChatMassage chatMassage)
    {
        Id = chatMassage.Id;
        SentTime = chatMassage.SentTime;
        EditTime = DateTime.Now;
        Content = chatMassage.Content;    
    }

    public override string ToString()
    {
        return $"{Id}\n{SentTime}\n{EditTime}\n{Content}";
    }

}
