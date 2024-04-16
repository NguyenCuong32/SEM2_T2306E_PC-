internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhập số dư ban đầu cho Tài khoản thường:");
        decimal soDuTaiKhoanThuong = Convert.ToDecimal(Console.ReadLine());
        ITaiKhoanNganHang taiKhoanThuong = new TaiKhoanThuong(soDuTaiKhoanThuong);

        Console.WriteLine("Nhập số dư ban đầu cho Tài khoản đổi ngoại tệ:");
        decimal soDuTaiKhoanDoiNgoaiTe = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Nhập tỷ giá (USD sang VND):");
        decimal tyGia = Convert.ToDecimal(Console.ReadLine());
        ITaiKhoanNganHang taiKhoanDoiNgoaiTe = new TaiKhoanDoiNgoaiTe(soDuTaiKhoanDoiNgoaiTe, tyGia);

        // Check số dư
        taiKhoanThuong.XemSoDu();
        taiKhoanDoiNgoaiTe.XemSoDu();

        // Chuyển khoản
        Console.WriteLine("Nhập số tiền để chuyển từ Tài khoản Thường:");
        decimal soTienChuyenTuTaiKhoanThuong = Convert.ToDecimal(Console.ReadLine());
        taiKhoanThuong.ChuyenKhoan(soTienChuyenTuTaiKhoanThuong);

        Console.WriteLine("Nhập số tiền để chuyển từ Tài khoản Đổi ngoại tệ (theo USD):");
        decimal soTienChuyenTuTaiKhoanDoiNgoaiTe = Convert.ToDecimal(Console.ReadLine());
        taiKhoanDoiNgoaiTe.ChuyenKhoan(soTienChuyenTuTaiKhoanDoiNgoaiTe);

        Console.ReadLine();
    }
}