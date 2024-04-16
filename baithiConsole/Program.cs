internal class Program
{
    private static void Main(string[] args)
    {
        TaiKhoanExchange taiKhoanExchange = new TaiKhoanExchange();
        taiKhoanExchange.Check();
        taiKhoanExchange.GuiTien(1000000);
        taiKhoanExchange.ChuyenKhoan(100000);
        taiKhoanExchange.TigiaHoidoai();

        // 
        TaikhoanThuong taikhoanThuong = new TaikhoanThuong();
        taikhoanThuong.GuiTien(1000);
        
    }
}