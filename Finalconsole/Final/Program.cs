using System;

namespace Final;

public class Program
{
    public static void Main(string[] args)
    {
        Account account = new Account();
        account.Balancer = 700000;

        ExchangeAccount exchangeAccount = new ExchangeAccount();
        exchangeAccount.CheckExchangeAccount(account);

        NormalAccount normalAccount = new NormalAccount();
        normalAccount.CheckBalance(account);

        Console.WriteLine("Enter your the ammount of transfer: ");
        double trans = Convert.ToDouble(Console.ReadLine());
        
        normalAccount.BankTransfer(trans, account);

    }
}

