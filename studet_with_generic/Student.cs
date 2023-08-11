using System;

public class Studet<TId, TGrade>
{
    public TId Id { get; set; }
    public string Name { get; set; }
    public TGrade Grade { get; set;}

    public Studet(TId id,string name, TGrade grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"Student:{Id}\nName:{Name}\nGrade{Grade}";
    }
}

