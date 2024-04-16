namespace T2306E_Test;

public interface IAccount
{
    double Balance { get; }
    void CheckBalance();
    void Transfer(double amount);
}
