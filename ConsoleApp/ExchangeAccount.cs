public class ExchangeAccount : BankAccount
{
    private decimal ExchangeRate { get; }

    public ExchangeAccount(decimal exchangeRate)
    {
        ExchangeRate = exchangeRate;
    }

    public override void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance * ExchangeRate:C}");
    }

    public override void Transfer(decimal amount)
    {
        decimal transferredAmount = amount * ExchangeRate;
        Balance -= transferredAmount;
        Console.WriteLine($"Your transferred {transferredAmount:C}, Your balance: {Balance * ExchangeRate:C}");
    }
}
