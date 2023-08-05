public static class CacheKeyConstants
{
    public static string Sum(List<int> hashcode)
    {
        int sum = 0;
        foreach (int item in hashcode)
        {
           sum += item.GetHashCode();
        }
        return $"{sum}-sum";
    }

    public static string Max(List<int> hashcode)
    {
        int max = 0;
        foreach (var item in hashcode)
        {
            max += item.GetHashCode();
        }
        return $"{max}-max";
    }

    public static string Min(List<int> hashcode)
    {
        int min = 0;
        foreach (var item in hashcode)
        {
            min += item.GetHashCode();
        }
        return $"{min}-min";
    }
 
}
