
namespace T2306E_Test;
    public class ExchangeAccount : IAccount
{
    public decimal balance;
    public decimal exchangeRate;

    public ExchangeAccount(decimal initialBalance, decimal initialExchangeRate)
    {
        balance = initialBalance;
        exchangeRate = initialExchangeRate;
    }

    public decimal Balance => balance;

    public void CheckBalance()
    {
        Console.WriteLine($"Your balance:{Balance * exchangeRate:C2}");
    }

    public void Transfer(decimal amount)
    {
        if (amount <= Balance)
        {
            balance -= amount;
            Console.WriteLine($"Transferred: {(amount * exchangeRate):C2}. Balance after transfer: {(Balance * exchangeRate):C2}");
        }
        else
        {
            Console.WriteLine("Insufficient funds for transfer.");
        }
    }
}

