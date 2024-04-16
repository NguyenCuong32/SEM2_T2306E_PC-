
using System;
using BankAccounts;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Normal Account:");
        IAccount normalAccount = new NormalAccount(25000000);
        normalAccount.CheckBalance();
        normalAccount.BankTransfer(1000000);

        Console.WriteLine("\nExchange Account:");
        IAccount exchangeAccount = new ExchangeAccount(1000, 25000);
        exchangeAccount.CheckBalance();
        exchangeAccount.BankTransfer(1000);
    }
}