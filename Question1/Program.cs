using Question1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Account System of Bank");
        Console.WriteLine("Enter your intitial amount: ");
        decimal.TryParse(Console.ReadLine(), out decimal amount);
        
        NormalAccount normal = new NormalAccount(amount);
        normal.CheckBalancer();

        Console.WriteLine("Enter your transfer amount: ");
        decimal.TryParse(Console.ReadLine(), out decimal transferamount1); 
        normal.Transfer(transferamount1);

        Console.WriteLine("\n");
        ExchangeAccount exchange = new ExchangeAccount(amount);
        exchange.CheckBalancer();

        Console.WriteLine("Enter your transfer amount: ");
        decimal.TryParse(Console.ReadLine(), out decimal transferamount2);
        normal.Transfer(transferamount2);

        Console.WriteLine("Enter your exchange amount: ");
        decimal.TryParse(Console.ReadLine(), out decimal exAmount);
        exchange.ExchangeRate(exAmount);
    }
}