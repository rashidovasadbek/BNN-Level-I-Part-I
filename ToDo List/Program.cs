using System.Collections.Generic;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("ToDo List".PadLeft(30));
Console.WriteLine("Display all-> d");
Console.WriteLine("mark done-> m");
Console.WriteLine("add-> a");

while (true)
{
    var todolist = new ToDoList();
    Console.WriteLine();
    Console.Write("Choose Command: ");
    var choose = char.Parse(Console.ReadLine());

    switch (choose)
    {
        case 'd':
            todolist.Display();
            Console.WriteLine("ortga-> 0");
            var chooseB = char.Parse(Console.ReadLine());
            if (chooseB == '0')
            {
                Console.Clear();
                todolist.Menu();
            }
            break;
        case 'm':
            todolist.MarkDone();
            Console.WriteLine("ortga-> 0");
            var chooseC = char.Parse(Console.ReadLine());
            if (chooseC == '0')
            {
                Console.Clear();
                todolist.Menu();
            }
            break;
        case 'a':
            bool temp = true;
            int count = 1;
            while (temp)
            {
                Console.WriteLine("task qo'shish-> y");
                Console.WriteLine("ortga-> 0");


                var chooseA = char.Parse(Console.ReadLine());
                if (chooseA == 'y')
                {
                    Console.Write("task name:");
                    var task_name = Console.ReadLine();
                    bool done = false;
                    todolist.tasklist.Add(new ToDo(task_name, done));
                }
                else if (chooseA == '0')
                {
                    Console.Clear();
                    foreach (var item in todolist.tasklist)
                    {
                        Console.Write(count++);
                        Console.WriteLine($".{item.taskName}");
                    }
                    temp = false;
                    todolist.Menu();

                }


            }
            break;
    }
}

//ToDo classini yaratish(taskName, doneORNotDone)
public class ToDo
{
    
    public ToDo(string taskName, bool done)
    {
        this.taskName = taskName;
        Done = done;
    }

    public string taskName { get; set; }
    public bool Done { get; set; }
}

//ToDoList clasini yaratish(List<TODo>, Display(), MArkDone(), Add())
public class ToDoList
{
    public List<ToDo> tasklist = new List<ToDo>();

    //Display() - Consolga Listning hamma itemslarini chiqazish, foreachdan foydalanilgan
    public void Display()
    {

        for(var indexA = 0; indexA < tasklist.Count; indexA++)
        
            Console.WriteLine(tasklist[indexA]);
        
    }

    //MarkDone() -foydalanuvchi komanda tanlaydi osha tanlangan comandani Task "Cooking" marked as done dep ekranga chiqazish
    public void MarkDone()
    {
        Console.Write("qaysi planni bajardingiz:");
        var index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hello");
            tasklist[index -1].Done = true;
            Console.WriteLine($"Task {tasklist[index -1].taskName} - mark as done");
     
        
    }

    //Add() -List ga yangi vazifa qo'shish 
    public void Add(ToDo taskname)
    {
           tasklist.Add(taskname);
    }

    public void Menu()
    {
        Console.WriteLine("ToDo List".PadLeft(30));
        Console.WriteLine("Display all-> d");
        Console.WriteLine("mark done-> m");
        Console.WriteLine("add-> a");
        
    }
}


