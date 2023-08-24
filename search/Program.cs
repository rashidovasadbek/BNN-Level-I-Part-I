using System.Reflection.Metadata;

MovieService movieService = new MovieService();

/*movieService.Add("huk", "Martin Scorsese", 10);
movieService.Add("Alob", "Quentin Tarantino", 9);
movieService.Add("baby", "Steven Spielberg", 3);
movieService.Add("Horrifying", "Christopher Nolan", 10);
movieService.Add("Mysterious", "James Cameron", 10);
movieService.Add("Scary", "Clint Eastwood", 10);
movieService.Add("Amazing", "Alfred Hitchcock", 10);

Console.WriteLine(movieService.Search("huk", "Martin Scorsese"));*/


movieService.movies.Add(new Movie("huk", "Martin Scorsese", 10));
movieService.movies.Add(new Movie("Alob", "Quentin Tarantino", 9));
movieService.movies.Add(new Movie("Horrifying", "Christopher Nolan", 10));
movieService.movies.Add(new Movie("baby", "Steven Spielberg", 3));
movieService.movies.Add(new Movie("Scary", "Clint Eastwood", 7));
movieService.movies.Add(new Movie("Amazing", "Alfred Hitchcock", 8));

/*foreach (var movie in movieService.Search("Alob", "Quentin Tarantino"))
{
    Console.WriteLine($"{movie.Name}-{movie.Auther}-{movie.Rating}");
}*/

foreach (var item in movieService.GetByRating())
{
    Console.WriteLine($"{item.Name}-{item.Auther}-{item.Rating}");
}
