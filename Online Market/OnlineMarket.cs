using System;


public class OnlineMarket
{
    List<Product> products = new List<Product>();

    private readonly IPaymentProvider _paymentProvider;
    private readonly IDebitCard _marketCard;

    public OnlineMarket(IPaymentProvider paymentProvider, IDebitCard debitCard)
    {
       _paymentProvider = paymentProvider;
       _marketCard = debitCard;
    }

    //productlar qatoriga berilgan productni qo'shsin
    public void Add(Product product)
    {
        products.Add(product);
    }

    //product lar ichidan berilgan nomdagi produktni berilgan sonda hisoblab, kartadan pul yechishni payment provider orqali amalga oshirsin
    public void Buy(string name, int number, IDebitCard yourCard)
    {
        foreach (var item in products)
        {
            if(name.Equals(item.ProductName,StringComparison.OrdinalIgnoreCase))
            {
                var amount = item.Price * number;
                if (yourCard.Balance > amount)
                {
                    _paymentProvider.Transfer(yourCard, _marketCard, amount);
                    Console.WriteLine($"Harid:{amount}");
                    break;
                }
                else
                {
                    Console.WriteLine("kartada mablag' yetari emas");break;
                }
               
            }  
            if(name.Contains(item.ProductName,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name} is not found");

            }
        }
        
    }
}
