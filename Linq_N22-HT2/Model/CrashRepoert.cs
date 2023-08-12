using System;
public class CrashReport : IReview
{
    public int Id { get; }
    public int Star { get; set; }
    public string Massage { get; set; }
    public string Screenshot { get; set; }
    public CrashReport(int id,int star, string massage, string screenshot)
    {
        Id = id;
        Star = star;
        Massage = massage;
        Screenshot = screenshot;

    }

    public override string ToString()
    {
        return $"id:{Id},Star:{Star},Massge:{Massage},Screenshot:{Screenshot}";
    }
}
