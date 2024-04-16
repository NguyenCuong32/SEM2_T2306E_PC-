using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class NormalAccount : Account
    {
        private decimal balance { get; set; }
        public NormalAccount(decimal InitialBalance)
        {
            balance = InitialBalance;
        }

        public decimal Balance { get => balance; }
        public void CheckBalancer()
        {
            Console.WriteLine($"Your Normal Account Balancer: {balance}đ");
        }

        public void Transfer(decimal TransferAmount)
        {
            if (TransferAmount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(TransferAmount), "Amount must be greater than 0");
            }
            if (TransferAmount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            balance -= TransferAmount;

            Console.WriteLine($"Your transfered: {TransferAmount}, Your balancer: {balance}");
        }
    }
}
