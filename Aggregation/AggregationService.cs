
public static class AggregationService
{
    public static int Sum(params int[] values)
    {
        int sum = 0;
        foreach (var item in values)
        {
            sum += item;
        }
        return sum;
    }

    public static int Average(params int[] values)
    {
        int sum = 0;
        foreach(var item in values)
            sum += item;
        return sum/values.Length;
    }

    public static int Max(params int[] values)
    {
        int max = 0;
        foreach( var item in values)
            if( item > max )
                max = item;
        return max;
    }

    public static int Min(params int[] values)
    {
        int min = values[0];
        foreach( int item in values)
            if( item < min )
                min = item;
        return min;
    }

    public static int Increment(ref int value)
    {
        if (value < int.MaxValue)
            value++;
        return value;
    }

    public static int Decrement(ref int value)
    {
        if (value > int.MinValue)
            value--;
        return value;
    }

}
