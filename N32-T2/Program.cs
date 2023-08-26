using N32_T2.Model;

ChatMassage chatMassageA = new ChatMassage(1,"test1","asdff",1,new DateTime(2023,5,2),new DateTime(2023,5,7));
ChatMassage chatMassageB = new ChatMassage(1, "test1", "asdff", 1, new DateTime(2023, 5, 2), new DateTime(2023, 5, 7));
ChatMassage chatMassageC = new ChatMassage(1, "test2", "asdff", 1, new DateTime(2023, 5, 2), new DateTime(2023, 5, 7));

if (chatMassageA.Equals(chatMassageB))
    Console.WriteLine("Equls");
else
    Console.WriteLine("not Equls");

