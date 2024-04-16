using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        IBankAccount regularAcconut = new RegularAccount();
        IBankAccount exchangeAccount = new ExchangeAccount(25000);

        while (true)
        {
            Console.WriteLine("chon tai khoan (1: thong thuong, 2: Exchange, 0: Thoát):");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
                break;
            else if (choice == 1)
                ProcessAccount(regularAcconut);
            else if (choice == 2)
                ProcessAccount(exchangeAccount);
            else
                Console.WriteLine("Lua chon khong hop le!");
        }
    }
    static void ProcessAccount(IBankAccount account)
    {
        Console.WriteLine("nhap so tien can chuyen:");
        decimal SoLuong = decimal.Parse(Console.ReadLine());
        account.ChuyenKhoan(SoLuong);
        account.HienThiSoDu();
    }
}