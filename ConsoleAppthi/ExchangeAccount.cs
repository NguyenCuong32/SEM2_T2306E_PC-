using System.ComponentModel;

public class ExchangeAccount  : IAccount {
    
    private double balance;
    private double tyso=25000;
    public ExchangeAccount(double Balance)
    {

        balance = Balance;
    }

    public void checkbalancer()
    {
        Console.WriteLine($"Your balance: {balance*tyso} đ");
    }

    public void banktransfer(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Your transferred {amount} đ. Your balance: {balance} đ");
        }
        else    
        {
            Console.WriteLine("Insufficient funds");
        }
    }
}
  