namespace Final;

public class ExchangeAccount : IAccount
{
    public void CheckExchangeAccount(Account account)
    {
        Console.WriteLine($"Checking Account balancing: {account.Balancer * 25000}");
    }
}