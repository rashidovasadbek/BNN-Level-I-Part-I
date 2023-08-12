using System;
using System;
public class Review : IReview
{
    public int Id { get; }
    public int Star { get; set; }
    public string Massage { get; set; }

    public Review(int id,int star, string massage)
    {
        Id = id;
        Star = star;
        Massage = massage;
    }

    public override string ToString()
    {
        return $"Id:{Id},Star:{Star},Massage:{Massage}";
    }
}

 
