namespace ConsoleApp1;

public abstract class BankAccount : IBankAccount
{
    protected decimal SoDu;

    public BankAccount()
    {
        SoDu = 25000000m;
    }

    public virtual void HienThiSoDu()
    {
        Console.WriteLine($"So du tai khoan cua ban: {SoDu:C} đ");
    }

    public abstract void ChuyenKhoan(decimal SoLuong);


}

