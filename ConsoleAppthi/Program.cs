internal class Program
{
    private static void Main(string[] args)
    {
         IAccount account = new ExchangeAccount(2000);
         account.checkbalancer();
         account.banktransfer(100);
         account.checkbalancer();
         IAccount account1 =new NormalAccount(2000000);
         account1.checkbalancer();
         account1.banktransfer(200000);
         account1.checkbalancer();
         
    }
}