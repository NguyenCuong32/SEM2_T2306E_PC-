namespace T2306E_Test;

public class Account:IAccount
{
public double Balance { get; protected set; }

    public virtual void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance:C2} đ"); 
    }

    public virtual void Transfer(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Transferred: {amount:C2} đ, New balance: {Balance:C2} đ");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}

