namespace Question1
{
    public class ExchangeAccount : Account
    {
        private decimal balance { get; set; }
        public ExchangeAccount(decimal InitialBalance)
        {
            balance = InitialBalance;
        }

        public decimal Balance { get => balance; }
        public void CheckBalancer()
        {
            Console.WriteLine($"Your Exchange Account Balancer: {balance}đ");
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

        public void ExchangeRate(decimal exAmmount)
        {
            decimal exRate = 25000;
            decimal exBalancer = 25000 * exAmmount;

            Console.WriteLine($"Today the exchange rate USD to VND is 25.000, your amount is {exBalancer}(USD)");
        }
    }
}
