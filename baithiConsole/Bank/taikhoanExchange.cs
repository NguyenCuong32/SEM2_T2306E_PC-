
public class TaiKhoanExchange : Bank, ITiGia
{   

    private readonly int numberTaiKhoanx = 567;
    public int numberTaiKhoanX { get => numberTaiKhoanx; }
    public override void Check()
    {
        System.Console.WriteLine($"So du tai khoan ban la: {this.Sodu}");
    }

    public override void ChuyenKhoan(double tienchuyen)
    {
        throw new NotImplementedException();
    }

    public override void GuiTien(double tiengui)
    {
        System.Console.Write(" nhap so tia khoan Extral ($): ");
        double taikh = Convert.ToDouble(Console.ReadLine());
        if(this.numberTaiKhoanX == taikh){
            this.Sodu += tiengui;
        }
        System.Console.WriteLine("gui tien thanh cong");
    }

    public double TigiaHoidoai()
    {
        
        return this.tigiahoidoi * this.Sodu;
    }
}