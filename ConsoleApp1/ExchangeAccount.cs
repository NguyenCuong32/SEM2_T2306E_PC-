namespace ConsoleApp1;

public class ExchangeAccount : Check
{
    public override double checkBalancer()
    {
        return balance = 25000000;
    }

    public override double transfer(double sotien)
    {
        return balance - sotien;
    }

    public double exchangeRate(double balance)
    {
        double dola = balance / 25000;
        return dola;
    }
}
