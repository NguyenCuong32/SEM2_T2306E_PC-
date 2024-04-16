namespace Test_01;

public class NormalAccount : BankAccount
{
    public NormalAccount(float balance) : base(balance) { }

    public override void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance} đ");
    }

    public override void BankTransfer(float amount)
    {
        Balance -= amount;
        Console.WriteLine($"Your transferred {amount} đ, Your balance is: {Balance} đ");
    }
}
