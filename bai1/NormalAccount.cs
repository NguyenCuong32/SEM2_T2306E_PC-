using System;

public class NormalAccount : BankAccount
{
    public NormalAccount(decimal balance) : base(balance) { }

    public override void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance} đ");
    }

    public override void BankTransfer(decimal amount)
    {
        Balance -= amount;
        Console.WriteLine($"Your transferred {amount} đ, Your balance: {Balance} đ");
    }
}
