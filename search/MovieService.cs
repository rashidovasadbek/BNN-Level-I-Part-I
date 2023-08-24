using System;
using System.Xml.Linq;

public class MovieService
{
   public  List<Movie> movies = new List<Movie>();
    public List<Movie> Search(string name, string auther )
    {
        var movie =  movies.Where(movies => movies.Name.Equals(name)|| movies.Auther.Equals(auther)).ToList();
        return movie;
    }

    public void Add(string name,string auther, int rating)
    {
        foreach (var item in movies) {
            if (movies.Any(movies => item.Name != name || item.Auther != auther))
                Console.WriteLine("Bu movie bor");break;
        }
        movies.Add(new Movie(name, auther, rating));

    }

    public IOrderedEnumerable<Movie> GetByRating() 
    {
        var movie = movies.OrderByDescending(movie => movie.Rating);
        return movie;
    }
}
