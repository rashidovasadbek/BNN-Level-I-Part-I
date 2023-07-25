using System.Diagnostics;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
var listProduct = new List<int>();
listProduct.Add(250);
listProduct.Add(200);
listProduct.Add(200);
listProduct.Add(100);
listProduct.Add(250);
listProduct.Add(100);
listProduct.Add(200);
listProduct.Add(200);
listProduct.Add(100);

Console.WriteLine(listProduct.Sum());
/*foreach(var item in listProduct)
{
    Console.WriteLine(item);
}*/
Console.WriteLine();
var result = listProduct.Distinct().ToArray();
/*foreach (var item in result)
{
    Console.WriteLine(item);
}*/

//var dict = new Dictionary<int, int>();
var count = 1;
for(int i = 0; i < result.Count(); i++)
{
    for(int j = i +1; j < listProduct.Count(); j++)
    {
        if (result[i] == listProduct[j])
        {
            count++;
        }
        if (count == 3)
        {
            listProduct.RemoveAt(j);
        }
    }
    count = 0;
}
Console.WriteLine(listProduct.Sum());

stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
Console.WriteLine(ts);