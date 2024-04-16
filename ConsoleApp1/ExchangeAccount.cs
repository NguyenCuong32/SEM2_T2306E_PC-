namespace ConsoleApp1;

public class ExchangeAccount : BankAccount

{
    private decimal TyGia;
    public ExchangeAccount(decimal TyGia)
    {
        this.TyGia = TyGia;
    }
    public override void HienThiSoDu()
    {
        Console.WriteLine($"so tai khoan của bạn: {SoDu:C} đ (ty gia hoi doai: {TyGia})");
    }

    public override void ChuyenKhoan(decimal SoLuong)
    {
        decimal sotientraodoi = SoLuong * TyGia;
        SoDu = sotientraodoi;
        Console.WriteLine($"Bạn đã chuyển khoản {SoLuong:C} đ, So dua cua ban: {SoDu:C} đ");
    }
}
