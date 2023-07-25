
Console.WriteLine("Yoshingizni kiriting");

try
{
    var age = int.Parse(Console.ReadLine());
    var age1 = age switch
    {
        < 18 => throw new ArgumentOutOfRangeException("Sorry,You are age too young"),

        >= 90 => throw new ArgumentOutOfRangeException("orry,You are age too old"),

        >= 18 and <= 90 => "Vaild age"

    };
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Dastur tugadi");
}
