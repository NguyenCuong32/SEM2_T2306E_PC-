using Project1;

internal class Program
{
    public static int Balance { get; private set; }

    private static void Main(string[] args)
    {
        Account account = new Account("Demo",1000);
        
        NormalAccount normalAccount = new NormalAccount("Demo",1000);
        normalAccount.checkbalancer();
        System.Console.WriteLine($"{normalAccount.Balance}");
        normalAccount.banktransfer();

        System.Console.WriteLine("**************************************");

        ExchangeAccount exchangeAccount = new ExchangeAccount("Demo",1000);
        exchangeAccount.checkbalancer();
        System.Console.WriteLine($"{exchangeAccount.Balance}");
        exchangeAccount.banktransfer();
        exchangeAccount.exchangerates();
        System.Console.WriteLine($"exchangerate {exchangeAccount.exchangerates()}");

    }
}