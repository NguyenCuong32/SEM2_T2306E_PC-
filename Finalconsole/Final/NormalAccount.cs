namespace Final;

public class NormalAccount : IAccount
{
    public void CheckBalance(Account account)
    {
        Console.WriteLine($"Your account balancing: {account.Balancer * 10000}");
    }

    public void BankTransfer(double transfer , Account account)
    {
        Console.WriteLine($"You've transfer {transfer}. Now your account balancing is: {(account.Balancer * 10000) - transfer}");
    }
}