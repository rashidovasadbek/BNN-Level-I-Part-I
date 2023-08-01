using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_weather
{
    public  class WeatherReport
    {
        public Dictionary<DateTime, string> weatherReportDictionary = new Dictionary<DateTime, string>();
        private string Find(DateTime date)
        {
            if (weatherReportDictionary.ContainsKey(date))
                return weatherReportDictionary[date];

            return null;
        }

        public void Get(DateTime dateTime)
        {
            var weather = Find(dateTime);

            if (weather == null)
                Console.WriteLine("Berilgan kunga ob-havo topilmadi, boshqa kunlar uchun qidiirb ko'ring");
            else
                Console.WriteLine(weather.ToString());
        }


        public virtual void Add(DateTime datetime, string malumot)
        {
            weatherReportDictionary.Add(datetime, malumot);
        }
    }
}
