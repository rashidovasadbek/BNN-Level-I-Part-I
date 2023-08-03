

namespace Car
{
    public  sealed  class Bmw : CarRental
    {
        public  string ModelName { get; set; }
        public static int RentPricePerHour { get; set; }

        public Bmw(string modelname) :
            base("BMW")
        {
           ModelName = modelname;
           RentPricePerHour = 30;    
        }
    }
}
