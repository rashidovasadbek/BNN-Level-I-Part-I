using System.Text.Json;

/*var result = new List<Person>
{
  new Person { Id = 1,Name = "G'ayrat",Age = 18},
  new Person { Id = 2,Name = "Bob",Age = 20},

};*/



string path = @"D:\.Net_myfolder\Country.txt";

/*string jsonPerson = JsonSerializer.Serialize(result);
Console.WriteLine(jsonPerson);
*/

/*using (StreamWriter writer = new StreamWriter(path, true))
    writer.Write(jsonPerson);*/

using (StreamReader  reder = new StreamReader(path))
{
    var people = JsonSerializer.Deserialize<List<>(reder.ReadToEnd());
    foreach(var item in people)
    {
        Console.WriteLine(item.Name);
    }
}

