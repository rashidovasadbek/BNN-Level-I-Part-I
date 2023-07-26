using System.Reflection.Metadata.Ecma335;

var cars = new List<Car>()
{
    new Car("Accord", "Honda"),
    new Car("Camry", "Toyota"),
    new Car("Civic", "Honda"),
    new Car("Accord", "Honda"),
    new Car("Elantra", "Hyundai"),
    new Car("Accord", "Honda"),
    new Car("Sonata", "Hyundai"),
    new Car("Elantra", "Hyundai"),
    new Car("Fusion", "Ford"),
    new Car("Malibu", "Chevrolet")
};

//var list = new List<Car>();

var duplicatesCount = new Dictionary<Car, int>();
foreach (var car in cars)
{
    if (!duplicatesCount.ContainsKey(car))
        duplicatesCount.Add(car, 1);
    else
        duplicatesCount[car]++;
}

foreach (var car in duplicatesCount)
    if (car.Value > 1)
    Console.WriteLine($"{car.Key.Name} {car.Key.Brand} - {car}");

//duplicatesCount[cars[indexA]]++


//for (int indexA = 0; indexA < cars.Count - 1; indexA++)
//{
//    var count = 1;

//    for (int indexB = indexA + 1; indexB < cars.Count; indexB++)
//    {
//        if (cars[indexA].Equals(cars[indexB]))
//        {
//            var exists = false;
//            foreach (var duplicateCar in list)
//                if (cars[indexA] == duplicateCar)
//                    exists = true;

//            if (exists)
//                break;

//            foreach (var duplicateCar in list)
//                if (cars[indexA].Equals(duplicateCar))
//                    exists = true;

//            if (!exists)
//                list.Add(cars[indexA]);

//            count++;
//        }
//    }

//    if (count > 1)
//        Console.WriteLine($"{cars[indexA].Name} {cars[indexA].Brand} - {count}");
//}

public class Car
{

    public Car(string name, string brand)
    {
        Name = name;
        Brand = brand;
    }
    public string Name { get; set; }
    public string Brand { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is Car car)
        {
            return this.GetHashCode() == car.GetHashCode();
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Brand.GetHashCode();
    }

}
