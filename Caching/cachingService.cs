
public class OrderCacheService
{
    private Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

    private static OrderCacheService _instance;
    private OrderCacheService()
    {
        
    }

    public static OrderCacheService  GetInstance()
    {
        if (_instance == null)
            _instance = new OrderCacheService();
        return _instance;
    }

    public string Get(string key)
    {

        return null;
    }

    public void Set(string key, int value)
    {
        
    }
}
