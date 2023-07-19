while (true)
{
    Console.WriteLine("Enter a number:");
    var num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a command:");
    var click = Char.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number:");
    var num2 = Convert.ToInt32(Console.ReadLine());
    
    switch (click) 
    {
        case '*': Console.WriteLine("Result:"+(num1 * num2)); break;
        case '/': Console.WriteLine("Result:" + (num1 / num2)); break;
        case '-': Console.WriteLine("Result:" + (num1 - num2)); break;
        case '+': Console.WriteLine("Result:" + (num1 + num2)); break;
        case 'e': Console.WriteLine("Thank you for using calculator"); return;
        default: Console.WriteLine("invalid choose:");break;
    }
}

