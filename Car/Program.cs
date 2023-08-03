using System.Diagnostics;
using Car;
CarRentalManagement carRentalManagement = new CarRentalManagement();
CarRental bmwA = new Bmw("X6");
CarRental bmwB = new Bmw("X5");
CarRental bmwC = new Bmw("X7");
CarRental audiA = new Audi("S");
CarRental audiB = new Audi("S luks");
CarRental audiC = new Audi("sport");
carRentalManagement.Add(bmwA);
carRentalManagement.Add(bmwB);
carRentalManagement.Add(bmwC);
carRentalManagement.Add(audiA);
carRentalManagement.Add(audiB);
carRentalManagement.Add(audiC);

var r2 = carRentalManagement.Rent("Audi");
    await Task.Delay(1000 * 2);
    carRentalManagement.Return(r2);
var r1 = carRentalManagement.Rent("BMW");
    await Task.Delay(1000 * 2);
   carRentalManagement.Return(r1);
var r3 = carRentalManagement.Rent("BMW");
    await Task.Delay(1000 * 3);
    carRentalManagement.Return(r1);



carRentalManagement.CalculateBalanse();



