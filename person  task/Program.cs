Person person = new Person();
Console.WriteLine(person);

Person person2 = new Person("asadbek",12,"tashkent","uzbek");
Console.WriteLine(person2.ToString());
Person person3 = new Person("Ali",18,"nuga","pachi");
Console.WriteLine(person3.ToString());
var person4 = new Person(person3);
Console.WriteLine(person4.ToString());

Console.WriteLine(User._name);
Console.WriteLine(User._age);
Console.WriteLine(User._city);
Console.WriteLine(User._nationality);
Console.WriteLine(User.Show());