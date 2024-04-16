using T2306E_Test;

internal class Program
{
    private static void Main(string[] args)
    {
        NormalAccount normalaccount = new NormalAccount();
        normalaccount.CheckBalance();
        ExchangeAccount exchangeaccount = new ExchangeAccount();
        exchangeaccount.CheckBalance();
        Console.WriteLine("Enter transfer amount: ");
        double transferAmount = double.Parse(Console.ReadLine());
        exchangeaccount.Transfer(transferAmount);
    }
}