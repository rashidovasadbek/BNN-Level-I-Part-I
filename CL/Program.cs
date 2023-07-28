
public class ClassroomAttendance
{
   protected Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
    
    public void Mark(string fullname, bool isPresent)
    {
        string present = "";
        string absent = "";

        if (isPresent)
            present = isPresent.ToString();
        else
            absent = isPresent.ToString();
    }

    internal protected void GetStats()
    {
        Console.WriteLine(keyValuePairs.Count/100);
    }

    public virtual void Display()
    {

    }

}

internal class UltimateClassroomAttendance : ClassroomAttendance
{
    public void Mark(string fullname,string isPresent,string couse = " ")
    {
        keyValuePairs.Add(fullname, isPresent + couse);
    }

    public override void Display()
    {
        base.Display();
        GetStats();
    }
}