public interface ICollectionAggregator
{
    List<T> Concat<T>(List<T> list1, List<T> list2);

    List<T> Intersect<T>(List<T> list1, List<T> list2);

    List<T> Except<T>(List<T> list1, List<T> list2);

    List<T> Union<T>(List<T> list1, List<T> list2);
}

public class CollectionAggregator : ICollectionAggregator
{
    public List<T> Concat<T>(List<T> list1, List<T> list2)
    {
        throw new NotImplementedException();
    }

    public List<T> Intersect<T>(List<T> list1, List<T> list2)
    {
        throw new NotImplementedException();
    }

    public List<T> Except<T>(List<T> list1, List<T> list2) 
    {
        throw new NotImplementedException();
    }

    public List<T> Union<T>(List<T> list1, List<T> list2) 
    {
        throw new NotImplementedException();
    }
}