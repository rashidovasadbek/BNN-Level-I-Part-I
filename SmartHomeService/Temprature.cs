using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTemprature
{
    public class Temprature
    {
        public double CurrentTemperature { get; set; }
        public double ExpectedTemperature { get; set; }
        public Temprature(double expected, double current)
        {
            ExpectedTemperature = expected;
            CurrentTemperature = current;
        }
        public override string ToString()
        {
            return $"Expected-{ExpectedTemperature},Current-{CurrentTemperature}";
        }
    }
}
