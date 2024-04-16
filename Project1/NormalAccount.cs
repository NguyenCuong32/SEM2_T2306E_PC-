namespace Project1;

public class NormalAccount : Account
{
    public NormalAccount(string BankAccount, int Balance) : base(BankAccount, Balance)
    {
        
    }
    public void checkbalancer(){
        System.Console.WriteLine($"check balance ");
    }
    public void banktransfer()
    {
        System.Console.WriteLine("bank transfer ");
    }
}
