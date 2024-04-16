using System;

public class ExchangeAccount : NormalAccount
{
    private decimal exchangeRate;

    public ExchangeAccount(decimal initialBalance, decimal exchangeRate) : base(initialBalance)
    {
        this.exchangeRate = exchangeRate;
    }

    public new void CheckBalance()
    {
        decimal balanceInUSD = base.balance;
        decimal balanceInVND = balanceInUSD * exchangeRate;
        Console.WriteLine($" balance: {balanceInVND:N2} VND");
    }

    public new void BankTransfer(decimal amount)
    {
        decimal amountInUSD = amount / exchangeRate;
        base.BankTransfer(amountInUSD);
    }
}
