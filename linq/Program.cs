Console.WriteLine("");

public interface ICollectionAggregator
{
    List<T> Concat<T>(List<T> listA, List<T> listB);

    List<T> Intersect<T>(List<T> listA, List<T> listB);

    List<T> Except<T>(List<T> listA, List<T> listB);

    List<T> Union<T>(List<T> listA, List<T> listB);
}

public class CollectionAggregator : ICollectionAggregator
{
    public List<T> Concat<T>(List<T> listA, List<T> listB)
    {
        var list = new List<T>();
        list.AddRange(listA);
        list.AddRange(listB);
        return list;
        throw new NotImplementedException();
    }

    public List<T> Intersect<T>(List<T> listA, List<T> listB)
    {
        var list = new List<T>();
        foreach (var itemA in listA)
        {
            if (!listB.Contains(itemA))
                list.Add(itemA);
        }
        throw new NotImplementedException();
    }

    public List<T> Except<T>(List<T> listA, List<T> listB)
    {
        var list = new List<T>();
        foreach (var itemA in listA)
        {
            if (listB.Contains(itemA))
                list.Add(itemA);
        }
        throw new NotImplementedException();
    }

    public List<T> Union<T>(List<T> listA, List<T> listB)
    {
        var list = new List<T>();
        list.AddRange(listA);
        foreach (var itemA in listA)
        {
            if (!listB.Contains(itemA))
                list.Add(itemA);
        }
        throw new NotImplementedException();
    }
}
