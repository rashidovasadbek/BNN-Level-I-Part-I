
Console.WriteLine("kitob name:");
var book_name = Console.ReadLine();
Console.WriteLine();

var book = new labraryManagment();

Book bok1 = new Book(1, "hoshimjon", "xudoyberdi");
Book bok2 = new Book(2, "orif", "lola");
Book bok3 = new Book(3, "dalalar", "jahon");
book.books.Add(bok1, 1);
book.books.Add(bok2, 3);
book.books.Add(bok3, 4);

foreach (var item in book.books)
{
    Console.WriteLine(item.Value);
}

Console.WriteLine(book.Checkout(book_name));

foreach (var item in book.books)
{
    Console.WriteLine(item.Value);
}
public class labraryManagment()
{
    public Dictionary<Book,int> books = new Dictionary<Book, int>();
    
    public bool Checkout(string bookname)
    {
        foreach(var book in books)
        {

            if(book.Key.Title.Contains(bookname) && book.Value > 0)
            {
                books[book.Key]--;
                return true;
            }
        
        }
        return false;    
    }
    
}

public class Book
{

    public Book(int id, string title, string auther)
    { 
        Id = id; 
        Title = title; 
        Auther = auther;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Auther { get; set; }

}

