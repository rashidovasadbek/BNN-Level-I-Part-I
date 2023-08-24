using System;

public class Emploee
{ 
    public int Id { get; set; } 
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Position Position { get; set; }
    public decimal Salary { get; set; }
    public int DepartmentId { get; set; }
    //public static int _count = 1000;
    public string No { get; set; }


    public Emploee(int id ,string firstName,string lastName,Position position, decimal salary, int depertmentID, string no) 
    {
        Id = id;
        FullName = firstName +" "+ lastName;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Salary = salary;
        DepartmentId = depertmentID;
        No = no;
    }
}

