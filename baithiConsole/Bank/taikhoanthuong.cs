
public class TaikhoanThuong : Bank
{   
    private readonly int numberTaiKhoan1 = 123;
    public int numberTaiKhoan { get => numberTaiKhoan1; }
    public override void Check()
    {
       System.Console.WriteLine($"So du tai khoan ban la: {this.Sodu}");
    }

    public override void ChuyenKhoan(double tienchuyen)
    {
        System.Console.Write(" nhap so tai khoan can chuyen: ");
        double taikh = Convert.ToDouble(Console.ReadLine());
        if(this.numberTaiKhoan == taikh){
            this.Sodu += tienchuyen/25000;
        }

    }

    public override void GuiTien( double tiengui )
    {
        System.Console.Write(" nhap so tia khoan Thuong(VND): ");
        double taikh = Convert.ToDouble(Console.ReadLine());
        if(this.numberTaiKhoan == taikh){
            this.Sodu = tiengui/25000;
        }
        System.Console.WriteLine($"gui tien thanh cong so tien {tiengui}");
    }
}