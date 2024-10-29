using System;
using System.Collections.Generic; // Bổ sung using cho List

public class sinhvien
{

    public String HoTen { get; set; }
    public String MSV { get; set; }
    public double DTB { get; set; }

    public void nhap()
    {
        Console.Write("Nhập tên sinh viên: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhập mã sinh viên: ");
        MSV = Console.ReadLine();

        Console.Write("Nhập điểm trung bình: ");
        DTB = Convert.ToDouble(Console.ReadLine());
    }

    public void hienthiSV()
    {
        Console.WriteLine($"Họ và tên: {HoTen}, MSSV: {MSV}, Điểm trung bình: {DTB:F2}");
    }
}

public class DanhSach
{
    private List<sinhvien> danhsach = new List<sinhvien>();

    public void themSV()
    {
        sinhvien sv = new sinhvien();
        sv.nhap();
        danhsach.Add(sv);
    }

    public void hienthiDS()
    {
        Console.WriteLine("\nDanh sách sinh viên:");
        foreach (var sv in danhsach)
        {
            sv.hienthiSV();
        }
    }

    public void TimSV(string mssv)
    {
        bool timThay = false;
        for (int i = 0; i < danhsach.Count; i++)
        {
            if (danhsach[i].MSV == mssv) // Sửa thành MSV thay vì MSSV
            {
                danhsach[i].hienthiSV();
                timThay = true;
                break;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy sinh viên với MSSV: " + mssv);
        }
    }

    public void timkiem()
    {
        if (danhsach.Count == 0)
        {
            Console.WriteLine("Danh sách sinh viên trống.");
            return;
        }

        sinhvien svDiemCaoNhat = danhsach[0]; // Giả sử sinh viên đầu tiên có điểm cao nhất
        for (int i = 1; i < danhsach.Count; i++)
        {
            if (danhsach[i].DTB > svDiemCaoNhat.DTB)
            {
                svDiemCaoNhat = danhsach[i];
            }
        }

        Console.WriteLine("\nSinh viên có điểm trung bình cao nhất:");
        svDiemCaoNhat.hienthiSV();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DanhSach danhSach = new DanhSach();

        Console.WriteLine("Nhập thông tin cho ít nhất 3 sinh viên:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nNhập thông tin sinh viên thứ {i + 1}:");
            danhSach.themSV(); // Sửa thành gọi phương thức đúng
        }

        danhSach.hienthiDS();

        // Tìm và hiển thị sinh viên có điểm trung bình cao nhất
        danhSach.timkiem();

        // Tìm kiếm sinh viên theo MSSV
        Console.Write("\nNhập MSSV để tìm kiếm sinh viên: ");
        string mssvTimKiem = Console.ReadLine();
        danhSach.TimSV(mssvTimKiem);
    }
}
