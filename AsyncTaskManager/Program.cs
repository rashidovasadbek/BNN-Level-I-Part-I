
using AsyncTaskManager.Model;
using AsyncTaskManager.Service;

var task1 = new TaskItem(1, "task 1", true);
var task2 = new TaskItem(2, "task 2", true);

var task = new Service();
var taskk1 = task.AddTaskAsync(task1);

if (taskk1)
{
    task.SaveTaskAsync(task1);
    Console.WriteLine("Sacssesfully");
}
var taskk2 = task.AddTaskAsync(task2);
if (taskk2)
{
    task.SaveTaskAsync(task2);
    Console.WriteLine("Sacssesfuly");
}


