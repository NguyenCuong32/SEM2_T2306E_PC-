namespace T2306E_Test;

public class NormalAccount:IAccount
{

    public decimal balance;

    public NormalAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public decimal Balance => balance;

    public void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance:C2}");
    }

    public void Transfer(decimal amount)
    {
        if (amount <= Balance)
        {
            balance -= amount;
            Console.WriteLine($"Transferred: {amount:C2}. Balance after transfer: {Balance:C2}");
        }
        else
        {
            Console.WriteLine("Insufficient funds for transfer.");
        }
    }

}
