var books = new List<Book>()
{
    new Book("Quen",5,"Jhon Doe"),
    new Book("Diqqat",1,"Jhon Doe"),
    new Book("Shamollar",8,"Tom"),
    new Book("Alpenist",3,"Jhon Doe"),
    new Book("shahar",7,"G'ayrat"),
};   

var book = books.OrderByDescending(books=> books.Rating).ToList();
foreach(var item in book)
    Console.WriteLine($"{item.Name}-{item.Rating}-{item.Auther}");
Console.WriteLine(books.First(book => book.Auther == "Jhon Doe").Name);
Console.WriteLine(books.Last(book => book.Auther == "Jhon Doe").Name);