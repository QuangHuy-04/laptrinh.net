using System;
public abstract class PhuongTien
{
    private string tenPT;
    private string loaiNL;
    public string TenPT
    {
        get { return tenPT; }
        set { tenPT = value; }
    }
    public string LoaiNL
    {
        get { return loaiNL; }
        set {  loaiNL = value; }
    }
    public PhuongTien(string tenPT, string loaiNL)
    {
        this.tenPT = tenPT;
        this.loaiNL = loaiNL;
    }
    public abstract void DiChuyen();
}
public interface IThongTinThem
{
    int TocDoToiDa(); 
    double MucTieuThuNhienLieu();
}
public class XeHoi : PhuongTien, IThongTinThem
{
    private int tocDoToiDa;
    private double mucTieuThuNhienLieu;

    
    public XeHoi(string tenPT, string loaiNL, int tocDoToiDa, double mucTieuThuNhienLieu)
        : base(tenPT, loaiNL)
    {
        this.tocDoToiDa = tocDoToiDa;
        this.mucTieuThuNhienLieu = mucTieuThuNhienLieu;
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPT} di chuyển bằng động cơ.");
    }

    public int TocDoToiDa()
    {
        return tocDoToiDa;
    }

    public double MucTieuThuNhienLieu()
    {
        return mucTieuThuNhienLieu;
    }
}


public class XeDap : PhuongTien, IThongTinThem
{
    private int tocDoToiDa;

    public XeDap(string tenPT, int tocDoToiDa) : base(tenPT, "khong co nhien lieu")
    {
        this.tocDoToiDa = tocDoToiDa;
    }

    
    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPT} di chuyen bang suc nguoi.");
    }

    
    public int TocDoToiDa()
    {
        return tocDoToiDa;
    }

    public double MucTieuThuNhienLieu()
    {
        return 0; 
    }
}

class Program
{
    static void Main(string[] args)
    {
    
        List<PhuongTien> dsPhuongTien = new List<PhuongTien>();
        dsPhuongTien.Add(new XeHoi("Xe Hơi the thao", "Xăng", 250, 10.5));  // Tốc độ 250 km/h, tiêu thụ 10.5 lít/100km
        dsPhuongTien.Add(new XeHoi("Xe Hơi gia dinh", "Dầu", 180, 7.0));   // Tốc độ 180 km/h, tiêu thụ 7 lít/100km
        dsPhuongTien.Add(new XeDap("Xe Đạp dia hinh", 40));               // Tốc độ 40 km/h
        dsPhuongTien.Add(new XeDap("Xe Đạp thong thuong", 25));              // Tốc độ 25 km/h

        foreach (var phuongTien in dsPhuongTien)
        {
            Console.WriteLine($"Phương tiện: {phuongTien.TenPT}, Loại nhiên liệu: {phuongTien.LoaiNL}");
            phuongTien.DiChuyen();

            if (phuongTien is IThongTinThem)
            {
                var thongTinThem = phuongTien as IThongTinThem;
                Console.WriteLine($"Tốc độ tối đa: {thongTinThem.TocDoToiDa()} km/h");

                // In mức tiêu thụ nhiên liệu nếu có
                if (phuongTien is XeHoi)
                {
                    Console.WriteLine($"Mức tiêu thụ nhiên liệu: {thongTinThem.MucTieuThuNhienLieu()} lít/100km");
                }
            }

            Console.WriteLine();
        }
    }
}