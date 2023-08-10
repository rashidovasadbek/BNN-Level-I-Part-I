using System;
using System.Text.RegularExpressions;

public class PaymePaymentProvider : IPaymentProvider
{
    public  double TransferInterest { get ; init; }
    public double minproviderSum = 5000;
    public PaymePaymentProvider(double  tranzaction = 0.5)
    {
        TransferInterest = tranzaction;
    }

    public bool Transfer(IDebitCard  sourceCard, IDebitCard  destinationCard, double amount)
    {
        if (string.IsNullOrEmpty(sourceCard.CardNumber) && sourceCard.CardNumber.Length !=20)
            return false;
        else
        {
            if (sourceCard.Balance > minproviderSum )
            {
                sourceCard.Balance -= amount + (TransferInterest * sourceCard.Balance) / 100;
                destinationCard.Balance += amount;
                
                Console.WriteLine("Kartangida " + sourceCard.Balance + " so'm qoldi");
            }
            return false;
        }

    }

}
