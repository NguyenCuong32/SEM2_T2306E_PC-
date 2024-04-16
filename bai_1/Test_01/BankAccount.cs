namespace Test_01;

public abstract class BankAccount
{
    public float Balance { get; set; }


    public BankAccount(float balance)
    {
        Balance = balance;
    }


    public abstract void CheckBalance();


    public abstract void BankTransfer(float amount);
}
