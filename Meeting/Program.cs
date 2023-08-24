List<Meeting> meetings = new List<Meeting>();
Meeting meeting = new Meeting("emam", TimeSpan.FromHours(3));
Meeting meeting1 = new Meeting("emam", TimeSpan.FromHours(2));
Meeting meeting2 = new Meeting("emam", TimeSpan.FromHours(4));
Meeting meeting3 = new Meeting("emam", TimeSpan.FromHours(1));

meetings.Add(meeting1);
meetings.Add(meeting2);
meetings.Add(meeting3);

var sum = new TimeSpan();

foreach ( var item in meetings)
{
    sum += item;
}

Console.WriteLine(sum);