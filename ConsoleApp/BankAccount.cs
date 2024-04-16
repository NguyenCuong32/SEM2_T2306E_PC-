    public abstract class BankAccount
    {
         protected decimal Balance { get; set; }

    public virtual void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance:C}");
    }

    public virtual void Transfer(decimal amount)
    {
        Balance -= amount;
        Console.WriteLine($"Your transferred {amount:C}, Your balance: {Balance:C}");
    }
    }