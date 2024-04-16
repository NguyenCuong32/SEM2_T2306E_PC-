public class TaiKhoanDoiNgoaiTe : ITaiKhoanNganHang
{
    private decimal soDu;
    private decimal tyGia;

    public TaiKhoanDoiNgoaiTe(decimal soDuBanDau, decimal tyGia)
    {
        soDu = soDuBanDau;
        this.tyGia = tyGia;
    }

    public decimal XemSoDu()
    {
        Console.WriteLine($"Số dư của bạn: {soDu * tyGia} đ");
        return soDu * tyGia;
    }

    public void ChuyenKhoan(decimal soTien)
    {
        if (soTien * tyGia <= soDu)
        {
            soDu -= soTien * tyGia;
            Console.WriteLine($"Bạn đã chuyển khoản: {soTien} đ");
            Console.WriteLine($"Số dư của bạn: {soDu * tyGia} đ");
        }
        else
        {
            Console.WriteLine("Số dư không đủ.");
        }
    }
}