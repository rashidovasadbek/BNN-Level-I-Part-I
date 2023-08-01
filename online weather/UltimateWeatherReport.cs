using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace online_weather
{
    internal class UltimateWeatherReport : ValidatedWeahterReport
    {
        public  SortedDictionary<DateTime, string> sortedDictionary = new SortedDictionary<DateTime, string>();
        public void Get(DateTime date, int datecounter)
        {
            int i = 0;
            foreach (var item in sortedDictionary)
            {
                if (item.Key.Month >= date.Month && item.Key.Day >= date.Day && i < datecounter)
                {
                    Console.WriteLine(item);
                    i++;
                }

            }
        }

        public void Get(int datecounter1)
        {
            Sort();
            int i = 0;
            foreach (var item1 in sortedDictionary)
            {
               
                if (item1.Key.Month >= DateTime.Now.Month && item1.Key.Day >= DateTime.Now.Day && i < datecounter1)
                {
                    Console.WriteLine(item1);
                    i++;
                }

            }
        }

        public void Sort() 
        {
            foreach (var key in weatherReportDictionary.Keys)
            {
                sortedDictionary[key] = weatherReportDictionary[key];
            }


        }

    }
}
