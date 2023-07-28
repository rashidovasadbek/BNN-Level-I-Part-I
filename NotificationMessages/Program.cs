
Console.WriteLine("search:");
var search = Console.ReadLine();
NotificationMessages notificationMessages = new NotificationMessages();

notificationMessages.SearchMessage(search);
public class NotificationMessages
{
    private Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
    
    protected void FindMessage(string messgageNameForFind)
    {
        keyValuePairs.Add("SuccRegistration", "You successfully registered");
        keyValuePairs.Add("AskPassword", "Enter your password");
        keyValuePairs.Add("Blocked", "our account has been blocked");
        
        foreach (var pair in keyValuePairs)
        {
            if (pair.Key.Contains(messgageNameForFind,StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(pair.Value);
        }

    }

    public void SearchMessage(string massageNameForSearch)
    {
        FindMessage(massageNameForSearch);
    }
}