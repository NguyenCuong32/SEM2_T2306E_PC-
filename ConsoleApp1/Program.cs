using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        ExchangeAccount exchangeAccount = new ExchangeAccount();
        NormalAccount normalAccount = new NormalAccount();
        System.Console.WriteLine($"Tỷ giá USD->VNĐ là : 25000đ / 1USD");
        double dola = exchangeAccount.exchangeRate(normalAccount.checkBalancer());
        Console.WriteLine($"Số dư trong tài khoản của bạn là : {normalAccount.checkBalancer()} đ");
        System.Console.WriteLine($"Tài khoản của bạn VNĐ->USD là : {dola}$");
        System.Console.WriteLine("Nhập số tiền bạn muốn chuyển:");
        double sotien = Convert.ToDouble(Console.ReadLine());
        normalAccount.transfer(sotien);
        System.Console.WriteLine($"Bạn đã chuyển {sotien}đ : số dư tài khoản của bạn là : {normalAccount.balance - sotien}đ");


    }
}