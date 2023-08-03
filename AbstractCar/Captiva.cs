
namespace AbstractCar
{
    public class Captiva : Car
    {

        public static int Passengers { get; set; }

        private readonly int maxspeed;
        
        public static int countsecunt = 0;
        public int Maxspeed { get;}

        public Captiva(string brand, int year, string color, int maxspeed, int passengers)
            : base(brand, year, color)

        {
            Maxspeed = maxspeed;
            Passengers = passengers;
        }

        public override void show()
        {
            base.show();
        }
        public override void Drive()
        {
            int startspeed = 0;
            Random random = new Random();
            while (startspeed < 100)
            {
                countsecunt++;
                startspeed += random.Next(1, 11);
                Console.WriteLine("Captiva:"+startspeed.ToString());
                Thread.Sleep(1000);
                //Console.Clear();
            }
           
        }
    
    
    
    }
}
