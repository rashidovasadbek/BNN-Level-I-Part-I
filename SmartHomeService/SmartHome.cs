using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestTemprature;

namespace HomeService
{
    public class SmartHomeService
    {
        private List<Temprature> tempratures = new();

        private bool _isActivated;
        public bool IsActivated { get => _isActivated; }

        public string DeviceName { get; init; }

        public double ExpectedTemperature
        {
            get
            {
                return tempratures[tempratures.Count - 1].ExpectedTemperature;
            }
            set
            {
                var lastCurrentTemperature = tempratures.Count > 0 ? tempratures[^1].CurrentTemperature : 0D;
                tempratures.Add(new Temprature(value, lastCurrentTemperature));
            }
        }

        public double CurrentTemperature
        {
            set
            {
                tempratures.Add(new Temprature(tempratures[tempratures.Count - 1].ExpectedTemperature, value));
            }
        }

        public SmartHomeService(string devicename)
        {
            _isActivated = false;
            DeviceName = devicename;
            tempratures = new List<Temprature>();
        }

        public void Activate()
        {
            _isActivated = true;
        }

        public void DisplayHomeTemperature()
        {
            if (_isActivated)
            {
                foreach (var item in tempratures)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Console.WriteLine("tempratura yoqing");
            }
        }

    }
}
