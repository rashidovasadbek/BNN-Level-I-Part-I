
var chat = new Chat();
var a = chat.Add("Let's get started");
chat.Display();
await Task.Delay(1000 * 2);
chat.Update(a, "I'm really sorry meeting is cancelled");
chat.Display();



