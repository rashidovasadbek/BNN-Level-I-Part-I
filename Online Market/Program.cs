
PaymePaymentProvider paymePaymentProvider = new PaymePaymentProvider();
OnlineMarket onlinemarket = new OnlineMarket(new PaymePaymentProvider(),new KapitalUzcard("8600 2345 5652 5653 7667","Asaka Bank",0));
Product product = new Product("pepsi",10000);
Product product1 = new Product("fanta", 12000);
Product product2 = new Product("olma", 5000);
Product product3 = new Product("nok", 8000);
onlinemarket.Add(product1);
onlinemarket.Add(product2);
onlinemarket.Add(product3);
onlinemarket.Add(product);
Console.Write("ProductName:");
var productName = Console.ReadLine();   
Console.Write("ProductNumber:");
var productNumber = Convert.ToInt32(Console.ReadLine());

KapitalUzcard kapitalUzcard = new KapitalUzcard("8600 2345 5652 5653 7667", "Asaka Bank",100000);


onlinemarket.Buy(productName, productNumber, kapitalUzcard);