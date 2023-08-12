using System;
using System.Collections.Generic;

public class ReviewList<TReview> : IReviewList<TReview> where TReview : IReview
{
    public List<TReview> _reviews;
    public ReviewList()
    {
        _reviews = new List<TReview>();
    }
    
    public void Add(TReview newReview)
    {
        _reviews.Add(newReview);
    }
    public void Update(int id, int  star, string message)
    {
        _reviews.Where(_reviews => _reviews.Id == id).ToList().ForEach( i =>
        {
            i.Star = star; 
            i.Massage = message;
        });
    }
    public void Remove(TReview review)
    {
      _reviews.Remove(review);          
    }
    public void Remove(int id)
    {
        _reviews.Remove(_reviews.Find(_reviews=> _reviews.Id == id));
    }
    public TReview? GetReview(int id)
    {
        foreach(var item in _reviews)
        {
            if(item.Id == id) return item;
        }
        return default(TReview);
        
    }
    public TReview? GetReview(string massage)
    {
       foreach (var item in _reviews)
            if(item.Massage.Equals(massage))
                return item;
       return default(TReview);
    }
    public bool GetOverallReview()
    {
        var oneStarReview = _reviews.Where(review => review.Star == 1).FirstOrDefault();
        
        if (_reviews.Count == 0)
        {
            Console.WriteLine("Be the first to leave a review for this product");
            return true;
        }
        else if (_reviews.All(_reviews => _reviews.Star == 5))
        {
            Console.WriteLine("Great news! All reviews for this product are 5-star ratings.");
            return true;
        }
        else if (oneStarReview is not null)
        {
            Console.WriteLine(oneStarReview.Massage);
            return true;
        }
        return false;
    }
}

