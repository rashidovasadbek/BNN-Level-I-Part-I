using AsyncTaskManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskManager.Service
{
    public class Service
    {
        List<TaskItem> tasks = new List<TaskItem>();
       
        public bool AddTaskAsync(TaskItem task)
        {
            tasks.Add(task);
            return true;
        }

        public bool ComplateTask(TaskItem task)
        {
          var taskItem = tasks.Find(task => task.Id == task.Id);
          return taskItem.IsCompleted = true;
        }

        public void SaveTaskAsync(TaskItem task)
        {
            var filename = $"{nameof(task)}.docx";
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteAsync($"{task.Id} {nameof(task)}");
            }
        }
    }
}
