namespace ConsoleApp1;

public class NormalAccount : BankAccount
{
    public override void ChuyenKhoan(decimal SoLuong)
    {
        SoDu = SoLuong;
        Console.WriteLine($"ban da chuyen khoan {SoLuong:C} đ, so du cua ban: {SoDu:C} đ");

    }
}
