using System;
public class DibitCard
{
    public string CardNumber { get; set; }
    public double Balance { get; set; }
    public DibitCard(string cardNumber, double balance)
    {
        CardNumber = cardNumber;
        Balance = balance;
    }
}
