using System;

public class MIlliyHumo : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public double Balance { get; set; }
}