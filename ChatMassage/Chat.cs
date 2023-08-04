
public class Chat 
{
    List<ChatMassage> chats;
    public Chat()
    {
        chats = new List<ChatMassage>();
    }

    public Guid Add(string content)
    {
       if(MessegeValidator.IsValidMessage(content))
        {  
            var message = new ChatMassage(content);
            chats.Add(message);
            var temp = message.Id;
            return temp;
        }
        else 
        { 
            return Guid.Empty; 
        }
        
    }

    public  void Update(Guid id,string content)
    {
        foreach (var messageItem in chats)
        {
            if( messageItem.Id == id)
            {  
                chats.Remove(messageItem);  
                var copy = new ChatMassage(messageItem);
                copy.Content = content;
                copy.EditTime = DateTime.Now;
                chats.Add(copy);
                break;

            }
            
        }
        
    }

    public void Display()
    {
        foreach (var messagedisplayItem in chats)
            Console.WriteLine($"{messagedisplayItem.Content} {messagedisplayItem.EditTime}");
    }
}
