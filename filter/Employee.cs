using System;
public class Employee
{   
    public string FirstName { get; set; }   
    public string LastName { get; set; }
    public double Salary { get; set; }
    public int Kpi { get; set; }

    public Employee(string firstname, string lastname, double salary, int kpi)
    {
        FirstName = firstname; 
        LastName = lastname; 
        Salary = salary;
        Kpi = kpi;
    }
    public Employee()
    {
        
    }

}

