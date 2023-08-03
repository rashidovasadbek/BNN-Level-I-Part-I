namespace Car
{
    public class CarRentalManagement
    {

        public List<CarRental> Cars { get; set; }
        public CarRentalManagement()
        {
            Cars = new List<CarRental>();

        }

        public void Add(CarRental car)
        {
            Cars.Add(car);
        }
        bool found = false;
        public CarRental Rent(string brandName)
        {
            foreach (var car in Cars)
            {
                if(car.BrandName.Contains(brandName))
                {
                    found = true;
                    car.RentStartTime = DateTime.Now;
                    car.IsRented = true;
                    return car;
                }
                
            }
            //if (!found)
        return null;
       }
        public void Return(CarRental car)
        {
           foreach(var item in Cars)
            {
                if(item.Id == car.Id)
                {
                    item.IsRented = false;
                    if (car.BrandName.Equals("BMW"))
                        car.Balance = (DateTime.Now - car.RentStartTime).TotalSeconds * Bmw.RentPricePerHour;
                    else if (car.BrandName.Equals("Audi"))
                        car.Balance = (DateTime.Now - car.RentStartTime).TotalSeconds * Audi.RentPricePerHour;
                }
            }
        }
        public void CalculateBalanse()
        {
            var calculateBalance = 0D;
            foreach (CarRental car in Cars)
                calculateBalance += car.Balance;
            
            Console.WriteLine(calculateBalance);
        }
    }
}
