using System.Text.Json;
using System.Xml;


TaskService taskService = new TaskService();
taskService.AddTask(new Tasks("do homework",Priorty.Medium,new DateTime(2023,8,9)));
//taskService.AddTask(new Tasks("run", Priorty.Medium, new DateTime(2023,5,7)));
//taskService.AddTask(new Tasks("sleep", Priorty.Medium, new DateTime(2023, 4, 5)));

string path = @"D:\.Net_myfolder\tasks.txt";
/*string jsontask = JsonSerializer.Serialize(taskService.GetTaksList());

using (StreamWriter writer = new StreamWriter(path, true))
    writer.Write(jsontask);*/

//using (StreamReader reder = new StreamReader(path))
{
    var task = JsonSerializer.Deserialize <List<Tasks>> (File.ReadAllText(path));
    foreach (var item in task)
    {
        Console.WriteLine($"Id:{item.Id}\n" +
            $"Description:{item.Description}\n" +
            $"Priority:{item.Priority}\n" +
            $"DeadLIne:{item.DeadLIne}\n" +
            $"IsCompleted:{item.IsCompleted}\n" +
            $"DeadLIne{item.DeadLIne}");
    }
}