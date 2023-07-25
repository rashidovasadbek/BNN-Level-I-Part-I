
Random random = new Random();
var rnd = random.Next(1, 10);

while (true)
{
    
    Console.Write("son kiriting:");
    var num = Console.ReadLine();
    try
    {

        if (int.TryParse(num, out var result))
        {
            if (result == rnd) Console.WriteLine("Congrets! You guessed it");
            else throw new ArgumentOutOfRangeException("You could't not guess");
        }
        else
        {
            throw new FormatException("Not a number");
        }
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(FormatException exe)
    {
        Console.WriteLine(exe.Message);
    }

}
