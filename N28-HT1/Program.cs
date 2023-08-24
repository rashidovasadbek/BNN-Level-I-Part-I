EventStack<IEvent> eventStack =  new EventStack<IEvent>();
eventStack.Push(new Event(1, "wedding",new TimeOnly(12,0,0)));
eventStack.Push(new Event(2, "epam meeting", new TimeOnly(12, 30, 0)));
eventStack.Push(new Event(3, "itransition meeting", new TimeOnly(13, 0, 0)));
eventStack.Push(new Event(4, "exadel meeting", new TimeOnly(14, 0, 0)));
eventStack.Push(new Event(5, "exadel meeting", new TimeOnly(18, 0, 0)));


Console.WriteLine(eventStack.Pop());
//Console.WriteLine(eventStack.Peek());