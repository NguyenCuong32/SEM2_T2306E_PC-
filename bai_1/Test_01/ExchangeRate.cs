namespace Test_01;

class ExchangeRate : BankAccount
{
    private float exchangeRate;


    public ExchangeRate(float balance, float exchangeRate) : base(balance)
    {
        this.exchangeRate = exchangeRate;
    }

    public override void CheckBalance()
    {
        float convertedBalance = Balance * exchangeRate;
        Console.WriteLine($"Your balance: {convertedBalance} đ");
    }

    public override void BankTransfer(float amount)
    {
        Balance -= amount;
        float transferredAmount = amount * exchangeRate;
        Console.WriteLine($"Your transferred {transferredAmount} đ, Your balance is: {Balance} đ");
    }
}
