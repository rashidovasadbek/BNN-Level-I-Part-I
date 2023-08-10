using System;

public class UzumPaymentProvider : IPaymentProvider
{
    public double TransferInterest { get ; init ; }
    public double minProviderSum = 5000;
    public UzumPaymentProvider(double tranzaksiya = 0.3)
    {
        TransferInterest = tranzaksiya;
    }
    
    public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
    {
        if (sourceCard.CardNumber.Length != 20 || string.IsNullOrEmpty(sourceCard.CardNumber))
            return false;
        else
        {
            if (sourceCard.Balance > minProviderSum)
                sourceCard.Balance -= amount - (TransferInterest * sourceCard.Balance)/100;
            destinationCard.Balance += amount;
            Console.WriteLine("Kartangida " + sourceCard.Balance + " so'm qoldi");
            return true;
        }
    }
}
