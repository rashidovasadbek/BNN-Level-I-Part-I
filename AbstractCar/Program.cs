
using AbstractCar;
//Console.WriteLine("captiva");
Captiva captiva = new Captiva("LTZ",2015,"qora",250,7);
//captiva.Drive();
//Console.WriteLine("Captiva:"+Captiva.countsecunt);
//Console.WriteLine("Malibu");
Malibu malibu = new Malibu("Primyer", 2016, "oq", 300, 5);
//malibu.Drive();
//Console.WriteLine("Malibu:" + Malibu.countsecunt);

Thread threadA = new Thread(captiva.Drive);
Thread threadB = new Thread(malibu.Drive);
Thread threadC = new Thread(captiva.Clear);


threadA.Start();
threadB.Start();
threadC.Start();



threadA.Join();
threadB.Join();
threadC.Join();