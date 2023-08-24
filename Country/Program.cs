using LessonProject;
using System.Text.Json;

string savePath = @"D:\.Net_myfolder\myfolder\Country\AllCounties.txt";

var jsonFile = File.ReadAllText(savePath);

var result = JsonSerializer.Deserialize<List<CountryModel>> (jsonFile);

/*foreach (var item in result)
{
    Console.WriteLine(item.Capital.Length);
}*/

/*object x = new();
Console.WriteLine(x);*/
