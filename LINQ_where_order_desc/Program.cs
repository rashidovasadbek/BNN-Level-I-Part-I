//where order desc
List<int> list = new List<int> { 2,3,5,3,6,3,4,7,98,8,7,5,54,11,17,19,13,4,7,8 };
var PrimeNUmbersList = new List<int>();
var prime_number = list.Where(prime => IsPrime(prime)).OrderDescending();
 foreach (var prime in prime_number)
    Console.WriteLine(prime);
bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (var index = 2; index < list.Count; index++)
    {
        if(number % index == 0)
        {
            return false;
        }
    }
    return true;
}