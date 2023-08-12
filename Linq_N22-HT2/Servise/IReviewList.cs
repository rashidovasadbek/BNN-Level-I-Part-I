using System;

public interface IReviewList<TReview> where TReview : IReview
{
    void Add(TReview newReview);
    void Update(int id, int star, string message);
    void Remove(int id);
    void Remove(TReview review);
    TReview GetReview(int id);
    TReview GetReview(string massage);
    bool GetOverallReview();

}