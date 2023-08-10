using System;

public interface IPaymentProvider
{
    //har bitta tranziaksiya uchun yechib olinadigan foiz
    public double TransferInterest { get; init; }

    //pulni bir kartadan ikkinchi cartaga o'tkazish
    bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount);

}
