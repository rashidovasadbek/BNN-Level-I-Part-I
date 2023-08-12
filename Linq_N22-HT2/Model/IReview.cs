using System;
public interface IReview
{
    int Id { get; }
    int Star { get; set; }
    string Massage { get; set; }
}
