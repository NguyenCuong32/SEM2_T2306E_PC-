namespace ConsoleApp1;

public class NormalAccount : Check
{
    public override double checkBalancer()
    {
        return balance = 25000000;
    }

    public override double transfer(double sotien)
    {
        return balance - sotien;
    }
}
