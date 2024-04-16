namespace T2306E_Test;

public class ExchangeAccount : Account, IExchangeable
{
    public double ExchangeRate { get; set; }

    public override void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance * ExchangeRate:C2} đ");
    }

    public double ConvertToVND(double amount)
    {
        return amount * ExchangeRate;
    }

    public override void Transfer(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Transferred: {amount:C2} đ, New balance: {(Balance * ExchangeRate):C2} đ");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}
