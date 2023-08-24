using System;
public class PaymentService
{
    
    public bool Checkout(double amount, DibitCard dibitCard)
    {
        if(amount > dibitCard.Balance) 
        { 
            dibitCard.Balance -= amount;
            return true;
        }
        return false;
    }
}
