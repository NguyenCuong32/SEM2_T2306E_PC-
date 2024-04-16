using System.ComponentModel;

public class NormalAccount : IAccount {
    
    private double balance;

    public NormalAccount(double Balance)
    {
        balance = Balance;
    }

    public void checkbalancer()
    {
        Console.WriteLine($"Your balance: {balance} đ");
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
            Console.WriteLine("khong du tien");
        }
    }
}
  