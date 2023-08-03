

namespace Car
{
    public abstract class CarRental
    {
        public bool IsRented { get; set; }
        public DateTime RentStartTime { get; set; }
        public double Balance { get; set; }
        public string BrandName { get; set; }
        public Guid Id { get; set; }

        protected CarRental(string brandName)
        {
            BrandName = brandName;
            Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"IsRented-{IsRented}\nRentStartTime{RentStartTime}\nBalance{Balance}\nBrandName{BrandName}\n{Id}";
        }
    }
}
