//string[] birthday = new string[5] {}
DateTime dateTime = DateTime.Now;
DateTime[] birthday = new DateTime[5];
birthday[0] = new DateTime(2003, 11, 12);
birthday[1] = new DateTime(2002, 5, 17);
birthday[2] = new DateTime(2007, 8, 19);
birthday[3] = new DateTime(2008, 2, 21);
birthday[4] = new DateTime(2009, 3, 1);

string[] name = new string[5];
name[0] = "Anavar";
name[1] = "Kamol";
name[2] = "Jamila";
name[3] = "Boxodir";
name[4] = "Jumagul";


var temp = birthday[0];
var temp1 = name[0];
for (int i = 0; i < 5 - 1; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (birthday[i].DayOfYear < birthday[j].DayOfYear)
        {
            temp = birthday[i];
            birthday[i] = birthday[j];
            birthday[j] = temp;

            temp1 = name[i];
            name[i] = name[j];
            name[j] = temp1;

        }
    }
}
for(int i = 0;i < 5; i++)
{
    Console.WriteLine($"{name[i]} {birthday[i]}");
}
