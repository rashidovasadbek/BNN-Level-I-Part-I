using System;

public class Book
{
    public string Name { get; set; }
    public int Rating { get; set; }
    public string Auther { get; set; }

    public Book(string name, int rating, string auhter)
    {
        Name = name;
        Rating = rating;
        Auther = auhter;
    }
}
