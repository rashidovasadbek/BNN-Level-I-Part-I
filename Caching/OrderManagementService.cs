
using System.Diagnostics.Tracing;

public class OrderManagementService 
{
    public List<int>  Orders = new List<int>();
     OrderCacheService Cache  = OrderCacheService.GetInstance();

    public int Max()
    {
        var key = CacheKeyConstants.Max(Orders);
        var max = Cache.Get(key);
        if (max != default)
            return max;
        else
        {
            var maxA = 0;
            foreach (var item in Orders)
            {
                if(item > maxA)
                    maxA = item;
            }
            Cache.Set(key, maxA);
            return maxA;
        }
    }
    public int Min()
    {
        var key = CacheKeyConstants.Max(Orders);
        var min = Cache.Get(key);
        if (min != default)
            return min;
        else
        {
            var minA = Orders[0];
            foreach (var item in Orders)
            {
                if (item < minA)
                    minA = item;
            }
            Cache.Set(key, minA);
            return minA;
        }
    }
    public int Sum()
    {
        var key = CacheKeyConstants.Max(Orders);
        var sum = Cache.Get(key);
        if (sum != default)
            return sum;
        else
        {
            var sumA = 0;
            foreach (var item in Orders)
            {
                sumA += item;   
            }
            Cache.Set(key, sumA);
            return sumA;
        }
    }
    public void Add(int amount)
    {
        Orders.Add(amount);
    }

}

