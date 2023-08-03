

namespace AbstractCar
{
    public abstract class Car
    {
        public string Brand { get; init; }
        public int Year { get; init; }
        public string Color { get; set; }

        public abstract void Drive();
        public virtual void show()
        {
            Console.WriteLine($"Brand-{Brand}\nYear-{Year}\nColor-{Color}\nMaxspeed-{Malibu.Maxspeed}\nPassengers-{Malibu.Passengers}");
        }
        public Car(string brand, int year, string color)
        {
            Brand = brand;
            Year = year;
            Color = color;
        }
        public virtual void Clear()
        {
            Console.WriteLine();
            Console.Clear();
        }
    }
}
