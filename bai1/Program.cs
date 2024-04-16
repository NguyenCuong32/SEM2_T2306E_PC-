using System;

class Program
{
    static void Main(string[] args)
    {

        BankAccount normalAccount = new NormalAccount(25000000m);
        normalAccount.CheckBalance();
        normalAccount.BankTransfer(1000000m);


        BankAccount exchangeAccount = new ExchangeAccount(25000000m, 25000m);
        exchangeAccount.CheckBalance();
        exchangeAccount.BankTransfer(1000000m);
    }
}
