
/*var a = 5;
var b = 6;
GetArea(a, b, out int P, out int S);
Console.WriteLine($"Peremetr:{P}\nYuza:{S}");
static void GetArea(int a, int b, out int P, out int S)
{
    P = 2 * (a + b);
    S = a * b;
}*/


/*var numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
static void FindMinMax(out int max, out int min, params int[] numbers)
{
    for(int indexA = 0; indexA < numbers.Length -1; indexA++)
    {
        for(int indexB = indexA +1;indexB <  numbers.Length; indexB++)
        {
            if (numbers[indexA] > numbers[indexB])
            {
                int temp = numbers[indexA];
                numbers[indexA] = numbers[indexB];
                numbers[indexB] = temp;
            }
        }
    }
    max = numbers[numbers.Length - 1];
    min = numbers[0];
    
}

FindMinMax(out int min, out int max, numbers);
Console.WriteLine();
Console.WriteLine(min);
Console.WriteLine(max);*/


Person person1 = new Person(name: "Ali", age: 12, false);
person1.Display(person1);
