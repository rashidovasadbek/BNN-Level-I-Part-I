using System;
public class Movie
{
    public string Name { get; set; }
    public string Auther { get; set; }
    public int Rating { get; set; }

    public Movie(string name, string auther, int rating)
    {
        Name = name;
        Auther = auther;
        Rating = rating;
    }

}
