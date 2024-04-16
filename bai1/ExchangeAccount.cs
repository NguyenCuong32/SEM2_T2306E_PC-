using System;


public class ExchangeAccount : BankAccount
{
    private decimal exchangeRate;


    public ExchangeAccount(decimal balance, decimal exchangeRate) : base(balance)
    {
        this.exchangeRate = exchangeRate;
    }

    public override void CheckBalance()
    {
        decimal convertedBalance = Balance * exchangeRate;
        Console.WriteLine($"Your balance: {convertedBalance} đ");
    }

    public override void BankTransfer(decimal amount)
    {
        Balance -= amount;
        decimal transferredAmount = amount * exchangeRate;
        Console.WriteLine($"Your transferred {transferredAmount} đ, Your balance: {Balance} đ");
    }
}
