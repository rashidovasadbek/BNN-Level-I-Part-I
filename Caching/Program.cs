OrderManagementService orderManagementService = new OrderManagementService();
orderManagementService.Add(134);
orderManagementService.Add(4335);
orderManagementService.Add(2343);
orderManagementService.Add(123);
orderManagementService.Add(3454);

Console.WriteLine(orderManagementService.Sum());
Console.WriteLine(orderManagementService.Max());
Console.WriteLine(orderManagementService.Min());

orderManagementService.Add(11);
orderManagementService.Add(456);
Console.WriteLine(orderManagementService.Sum());
Console.WriteLine(orderManagementService.Min());


