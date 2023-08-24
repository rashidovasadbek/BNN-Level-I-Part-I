EmployeeService employeeService = new EmployeeService();
var response = employeeService.GetBySalary(5, 1);
foreach (var item in response)
    Console.WriteLine($"{item.FirstName} - {item.LastName} - {item.Salary}");


