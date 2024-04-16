namespace Project1;

public class ExchangeAccount : Account
{
    internal static readonly object exchangerate;

    public ExchangeAccount(string BankAccount, int Balance) : base(BankAccount, Balance)
    {
    }
    public void checkbalancer ()
    {
        System.Console.WriteLine("check balance ");
    }
    public void banktransfer ()
    {
        System.Console.WriteLine("bank transfer ");
    }
    public int exchangerates()
    {
        return Balance * 25;
    }
}
