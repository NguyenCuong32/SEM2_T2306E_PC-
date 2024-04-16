namespace BankAccounts
{
    public interface IAccount
    {
        void CheckBalance();
        void BankTransfer(decimal amount);
    }
}
