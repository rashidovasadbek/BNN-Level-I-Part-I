using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_weather
{
 internal class ValidatedWeahterReport : WeatherReport
    {
        string change = "";
        public override void Add(DateTime datetime, string malumot)
        {
            if (weatherReportDictionary.ContainsKey(datetime))
            {
                Console.WriteLine("bu kungi ob-havo malumotlari bor. Ob - havo malumotini o'zgartirishingiz mumkun");
                change = Console.ReadLine();
                weatherReportDictionary[datetime] = change;
            }
            else
                weatherReportDictionary.Add(datetime, malumot);
  
            foreach(var item  in weatherReportDictionary)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
