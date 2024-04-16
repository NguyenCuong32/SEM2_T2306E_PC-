public class TaiKhoanThuong : ITaiKhoanNganHang
{
    private decimal soDu;

    public TaiKhoanThuong(decimal soDuBanDau)
    {
        soDu = soDuBanDau;
    }

    public decimal XemSoDu()
    {
        Console.WriteLine($"Số dư của bạn: {soDu} đ");
        return soDu;
    }

    public void ChuyenKhoan(decimal soTien)
    {
        if (soTien <= soDu)
        {
            soDu -= soTien;
            Console.WriteLine($"Bạn đã chuyển khoản: {soTien} đ");
            Console.WriteLine($"Số dư của bạn: {soDu} đ");
        }
        else
        {
            Console.WriteLine("Số dư không đủ.");
        }
    }
}