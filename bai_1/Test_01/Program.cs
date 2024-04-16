namespace Test_01;
class Program
{
    static void Main(string[] args)
    {

        BankAccount normalAccount = new NormalAccount(3000f);
        normalAccount.CheckBalance();
        normalAccount.BankTransfer(1000f);


        BankAccount exchangeAccount = new ExchangeRate(1000f, 2000f);
        exchangeAccount.CheckBalance();
        exchangeAccount.BankTransfer(10f);
    }
}
