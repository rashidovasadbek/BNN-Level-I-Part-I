


using online_weather;

using System.ComponentModel;
/*Console.WriteLine("ob-havoni kiriting: yil, oy, kun");
var weatherreport = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Console.WriteLine("ob-havo haqida malumot kiriting:");
string malumot = Console.ReadLine();*/

WeatherReport weatherReport = new WeatherReport();
/*weatherReport.weatherReportDictionary.Add(new DateTime(2023, 7, 2), "Quyoshli Sharqdan sekundiga 2 m/s");
weatherReport.weatherReportDictionary.Add(new DateTime(2023, 7, 3), "Quyoshli Sharqdan sekundiga 5 m/s");
weatherReport.weatherReportDictionary.Add(new DateTime(2023, 7, 4), "Yomg'irli Sharqdan sekundiga 6 m/s");
weatherReport.weatherReportDictionary.Add(new DateTime(2023, 7, 5), "Bulutli Sharqdan sekundiga 12 m/s");
weatherReport.weatherReportDictionary.Add(new DateTime(2023, 7, 6), "Quyoshli Sharqdan sekundiga 7 m/s");
weatherReport.weatherReportDictionary.Add(new DateTime(2023, 7, 7), "Yomg'ir Sharqdan sekundiga 9 m/s");*/


//weatherReport.Get(weatherreport);

ValidatedWeahterReport validatedWeahterReport = new ValidatedWeahterReport();
/*validatedWeahterReport.weatherReportDictionary.Add(new DateTime(2023, 7, 2), "Quyoshli Sharqdan sekundiga 2 m/s");
validatedWeahterReport.weatherReportDictionary.Add(new DateTime(2023, 7, 3), "Quyoshli Sharqdan sekundiga 5 m/s");
validatedWeahterReport.weatherReportDictionary.Add(new DateTime(2023, 7, 4), "Yomg'irli Sharqdan sekundiga 6 m/s");
validatedWeahterReport.weatherReportDictionary.Add(new DateTime(2023, 7, 5), "Bulutli Sharqdan sekundiga 12 m/s");
validatedWeahterReport.weatherReportDictionary.Add(new DateTime(2023, 7, 6), "Quyoshli Sharqdan sekundiga 7 m/s");
validatedWeahterReport.weatherReportDictionary.Add(new DateTime(2023, 7, 7), "Yomg'ir Sharqdan sekundiga 9 m/s");*/

//validatedWeahterReport.Add(weatherreport, malumot);

UltimateWeatherReport ultimateWeatherReport = new UltimateWeatherReport();
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,7,31), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,5), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,2), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,10), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,1), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,9), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,7), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,4), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,6), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,13), "Yomg'ir Sharqdan sekundiga 9 m/s");
ultimateWeatherReport.weatherReportDictionary.Add(new DateTime(2023,8,15), "Yomg'ir Sharqdan sekundiga 9 m/s");

Console.WriteLine("datecount:");
int datecount = int.Parse(Console.ReadLine());

//ultimateWeatherReport.Get(weatherreport, datecount);
ultimateWeatherReport.Get(datecount);
