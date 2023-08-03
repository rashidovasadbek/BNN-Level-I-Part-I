
namespace Car
{
    public sealed class Audi : CarRental
    {
        public string ModelName { get; set; }
        public static int RentPricePerHour { get; set; }

        public Audi(string modelname) :
            base("Audi")
        {
            ModelName = modelname;
            RentPricePerHour = 10;
        }
    }
}
