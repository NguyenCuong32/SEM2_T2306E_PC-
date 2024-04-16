
public abstract class Bank {
    public double tigiahoidoi = 25000;
    
    private double sodu = 1000;

    
    public double Sodu { get => sodu; set => sodu = value; }

    public abstract void ChuyenKhoan(double tienchuyen);
    public abstract void Check();
    public abstract void GuiTien(double tiengui);

}