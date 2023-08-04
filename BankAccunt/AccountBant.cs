public  class AccountBant
{

    protected string _accountHolderName;
    protected int _accountNumber;
    protected decimal _balance;

    public AccountBant(string accountHolder, int accountNumber, decimal balance)
    {
        _accountHolderName = accountHolder;
        _accountNumber = accountNumber;
        _balance = balance;
    }
    public virtual void Deposit(decimal addBalance)
    {
        if (addBalance < _balance)
            Console.WriteLine("Mablag' yetarli emas!");
    }

    public virtual void Rebalance(decimal setBalanse)
    {

    }
}

