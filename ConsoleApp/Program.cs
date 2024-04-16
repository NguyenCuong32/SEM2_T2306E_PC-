internal class Program
{
    private static void Main(string[] args)
    {
       decimal exchangeRate = 25000; 

        BankAccount normalAccount = new NormalAccount();
        BankAccount exchangeAccount = new ExchangeAccount(exchangeRate);

        Console.WriteLine("Normal Account:");
        normalAccount.CheckBalance();
        normalAccount.Transfer(1000000);
        Console.WriteLine();

        Console.WriteLine("Exchange Account:");
        exchangeAccount.CheckBalance();
        exchangeAccount.Transfer(1000); 
        }

    }
