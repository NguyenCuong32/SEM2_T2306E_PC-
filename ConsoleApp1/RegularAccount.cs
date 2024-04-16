namespace ConsoleApp1;

public class RegularAccount : BankAccount
{
    public override void ChuyenKhoan(decimal SoLuong)
    {
        SoDu = SoLuong;
        Console.WriteLine($"ban da chuyen khoan {SoLuong:C} đ, So dua cua ban: {SoDu:C} đ");
    }
}
