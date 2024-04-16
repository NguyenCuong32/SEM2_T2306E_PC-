namespace ConsoleApp1;

public abstract class Check
{
    public double balance { get; set; }
    public abstract double checkBalancer();
    public abstract double transfer(double sotien);
}
