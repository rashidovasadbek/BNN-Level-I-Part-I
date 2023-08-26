
var username = new List<string> 
{ 
    "Boxodir007",
    "Alish41",
    "Ali_okeng",
    "Tohir algo",
    "Shomurod",
    "Kamol_kru",
    "Malika_03"
};
//userlarga file larni ochish
var createFileTasks = username.Select(username => Task.Run(() =>
{
    var fileStream = File.Create($"{username.ToLower()}.docx");
    Console.WriteLine($"{username} ga file yaratildi");
    return fileStream;
}));
var userFiles = (await Task.WhenAll(createFileTasks)).ToList();