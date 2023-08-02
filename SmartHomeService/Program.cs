using TestTemprature;
using HomeService;

// kanstrukterdan kelgan is Activated ni true yoki false qilib tekshiring!
SmartHomeService smartHomeService = new SmartHomeService("MK34");
smartHomeService.Activate();

smartHomeService.ExpectedTemperature = 28;

smartHomeService.CurrentTemperature = 25;
smartHomeService.CurrentTemperature = 27;

smartHomeService.ExpectedTemperature = 20;

smartHomeService.CurrentTemperature = 28;
smartHomeService.CurrentTemperature = 25;

if(smartHomeService.IsActivated == true)
    Console.WriteLine(smartHomeService.DeviceName);

smartHomeService.DisplayHomeTemperature();

















