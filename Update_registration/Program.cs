
Registration registration = new Registration();
Console.WriteLine("User Registration".PadLeft(35));
while (true)
{
    Console.WriteLine("1.Registor:");
    Console.WriteLine("2.Display:");

    var choose = int.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            Console.Write("Enter Name:");
            var name = Console.ReadLine();
            Console.Write("Enter LastName:");
            var lastName = Console.ReadLine();
            Console.Write("Enter MiddleName:");
            var middleName = Console.ReadLine();
            Console.Write("Enter EmailAddress:");
            var emailAddress = Console.ReadLine();
            Console.Write("Enter UserName:");
            var userName = Console.ReadLine();
            Console.Clear();
            registration.Registor(name, lastName, middleName, emailAddress, userName);
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Name       |Lastname       |Middlename       |EmailAddress              |Username ");
            registration.Display();
            break;
        default: Console.WriteLine("Invalid choose"); break;

    }
}