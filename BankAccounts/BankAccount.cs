using System;

namespace BankAccounts
{
    public class NormalAccount : IAccount
    {
        private decimal balance;

        public NormalAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"balance: {balance:N2} VND");
        }

        public void BankTransfer(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Số dư sau khi chuyển: {balance:N2} VND");
            }
            else
            {
                Console.WriteLine("Insufficient balance for transfer.");
            }
        }
    }
}
