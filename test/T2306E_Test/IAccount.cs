namespace T2306E_Test;

public interface IAccount
{
    public decimal Balance { get; }
    public void CheckBalance();
    public void Transfer(decimal amount);

           
}
