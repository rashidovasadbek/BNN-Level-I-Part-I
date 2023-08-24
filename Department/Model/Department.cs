using System;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string WorkerLimit { get; set; }
    public string SalaryLimit { get; set; }

    List<Emploee> Emploes  = new List<Emploee>();

    public Department(int id, string name, string workerLimit, string salaryLimit)
    {
        Id = id;
        Name = name;
        WorkerLimit = workerLimit;
        SalaryLimit = salaryLimit;
    }
}
