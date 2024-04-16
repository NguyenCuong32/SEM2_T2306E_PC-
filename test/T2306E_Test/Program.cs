using T2306E_Test;

internal class Program
{
    private static void Main(string[] args)
    {
      Console.WriteLine("Select account type (a:Normal, b:Exchange):");
        string choice = Console.ReadLine();

        IAccount account = null;
        decimal initialBalance, exchangeRate = 1.0m; // Default exchange rate

        if (choice == "a")
        {
            Console.WriteLine("Enter initial balance:");
            initialBalance = decimal.Parse(Console.ReadLine());
            account = new NormalAccount(initialBalance);
        }
        else if (choice == "b")
        {
            Console.WriteLine("Enter initial balance:");
            initialBalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter exchange rate:");
            exchangeRate = decimal.Parse(Console.ReadLine());
            account = new ExchangeAccount(initialBalance, exchangeRate);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
    }
}
}