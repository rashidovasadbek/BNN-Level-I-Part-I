
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

    public int Get(string key)
    {
        if (keyValuePairs.ContainsKey(key))
            return keyValuePairs[key];
        return default;
    }

    public void Set(string key, int value)
    {
        if(keyValuePairs.ContainsKey(key))
            keyValuePairs[key] = value;

    }
}
