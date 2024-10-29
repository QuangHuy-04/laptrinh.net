
//public class ConNguoi
//{
//    public string Name;
//    public int Age;

//    // Constructor (Phương thức khởi tạo)
//    public ConNguoi(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//    // Phương thức (Method) của lớp
//    public void HienThi()
//    {
//        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
//    }
//}
//// Tạo đối tượng từ lớp Person và sử dụng nó bên ngoài lớp Person
//class Program
//{
//    static void Main(string[] args)
//    {
//        ConNguoi person1 = new ConNguoi("Duong", 20);


//        person1.HienThi();
//    }
//}


//dong goi
//public class ConNguoi 
//{
//    private String name;
//    private int age;
//    public String Name
//    { 
//        get { return name; } 
//        set { name = value; }
//    }
//    public int Age
//    {   
//        get { return age; } 
//        set { age = value; } 
//    }
//    public ConNguoi(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//    public void HienThi()
//    {
//        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        ConNguoi CN=new ConNguoi("Duongsh", 20);
//        CN.HienThi();
//    }
//}





// ke thua

//public class ConNguoi
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    // Constructor để khởi tạo đối tượng ConNguoi
//    public ConNguoi(string name, int age)
//    {
//        this.Name = name;
//        this.Age = age;
//    }

//    // Phương thức hiển thị thông tin
//    public void HienThiThongTin()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {Age}");
//    }
//}

//// Lớp con SinhVien kế thừa từ lớp ConNguoi
//public class SinhVien : ConNguoi
//{
//    public string MaSinhVien { get; set; }
//    public string ChuyenNganh { get; set; }

//    // Constructor của SinhVien sử dụng từ khóa base để gọi constructor lớp cha
//    public SinhVien(string name, int age, string maSinhVien, string chuyenNganh)
//        : base(name, age) // Gọi constructor của lớp cha ConNguoi
//    {
//        this.MaSinhVien = maSinhVien;
//        this.ChuyenNganh = chuyenNganh;
//    }

//    // Phương thức hiển thị thông tin sinh viên
//    public void HienThiThongTinSinhVien()
//    {
//        // Gọi phương thức của lớp cha để hiển thị thông tin cơ bản
//        base.HienThiThongTin();
//        Console.WriteLine($"Mã sinh viên: {MaSinhVien}, Chuyên ngành: {ChuyenNganh}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Tạo đối tượng SinhVien
//        SinhVien sv = new SinhVien("Nguyen Van A", 20, "SV12345", "Công nghệ thông tin");

//        // Gọi phương thức để hiển thị thông tin sinh viên
//        sv.HienThiThongTinSinhVien();
//    }
//}

//Đa hình (Polymorphism)

// Lớp cha ConNguoi
//public class ConNguoi
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    // Constructor để khởi tạo đối tượng ConNguoi
//    public ConNguoi(string name, int age)
//    {
//        this.Name = name;
//        this.Age = age;
//    }

//    // Phương thức ảo để hiển thị thông tin (sẽ được ghi đè ở lớp con)
//    public virtual void HienThiThongTin()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {Age}");
//    }
//}

// Lớp con SinhVien kế thừa từ lớp ConNguoi
//public class SinhVien : ConNguoi
//{
//    public string MaSinhVien { get; set; }
//    public string ChuyenNganh { get; set; }

//    // Constructor của SinhVien sử dụng từ khóa base để gọi constructor lớp cha
//    public SinhVien(string name, int age, string maSinhVien, string chuyenNganh)
//        : base(name, age) // Gọi constructor của lớp cha
//    {
//        this.MaSinhVien = maSinhVien;
//        this.ChuyenNganh = chuyenNganh;
//    }

//    // Ghi đè phương thức HienThiThongTin của lớp cha
//    public override void HienThiThongTin()
//    {
//        Console.WriteLine($"Sinh viên: {Name}, Tuổi: {Age}, Mã sinh viên: {MaSinhVien}, Chuyên ngành: {ChuyenNganh}");
//    }
//}

//// Lớp con GiangVien kế thừa từ lớp ConNguoi
//public class GiangVien : ConNguoi
//{
//    public string MaGiangVien { get; set; }
//    public string MonHocDay { get; set; }

//    // Constructor của GiangVien sử dụng từ khóa base để gọi constructor lớp cha
//    public GiangVien(string name, int age, string maGiangVien, string monHocDay)
//        : base(name, age) // Gọi constructor của lớp cha
//    {
//        this.MaGiangVien = maGiangVien;
//        this.MonHocDay = monHocDay;
//    }

//    // Ghi đè phương thức HienThiThongTin của lớp cha
//    public override void HienThiThongTin()
//    {
//        Console.WriteLine($"Giảng viên: {Name}, Tuổi: {Age}, Mã giảng viên: {MaGiangVien}, Môn dạy: {MonHocDay}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Đa hình: Sử dụng lớp cha ConNguoi để tham chiếu đến đối tượng lớp con SinhVien và GiangVien
//        ConNguoi sinhVien = new SinhVien("Nguyen Van A", 20, "SV12345", "Công nghệ thông tin");
//        ConNguoi giangVien = new GiangVien("Tran Van B", 45, "GV54321", "Lập trình C#");

//        // Gọi phương thức HienThiThongTin sẽ thực thi phương thức tương ứng của lớp con
//        sinhVien.HienThiThongTin(); // Gọi phương thức của SinhVien
//        giangVien.HienThiThongTin(); // Gọi phương thức của GiangVien
//    }
//}


//Trừu tượng (Abstraction) 

// Lớp trừu tượng ConNguoi
public abstract class ConNguoi
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor cho lớp ConNguoi
    public ConNguoi(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Phương thức trừu tượng, không có phần thân (phải được lớp con ghi đè)
    public abstract void HienThiThongTin();
}

// Lớp SinhVien kế thừa từ lớp trừu tượng ConNguoi
public class SinhVien : ConNguoi
{
    public string MaSinhVien { get; set; }
    public string ChuyenNganh { get; set; }

    // Constructor của SinhVien, gọi đến constructor của lớp cha
    public SinhVien(string name, int age, string maSinhVien, string chuyenNganh)
        : base(name, age) // Gọi constructor lớp cha
    {
        this.MaSinhVien = maSinhVien;
        this.ChuyenNganh = chuyenNganh;
    }

    // Ghi đè phương thức trừu tượng từ lớp cha
    public override void HienThiThongTin()
    {
        Console.WriteLine($"Sinh viên: {Name}, Tuổi: {Age}, Mã sinh viên: {MaSinhVien}, Chuyên ngành: {ChuyenNganh}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng SinhVien
        ConNguoi sinhVien = new SinhVien("Nguyen Van A", 20, "SV12345", "Công nghệ thông tin");

        // Gọi phương thức HienThiThongTin (được triển khai bởi lớp SinhVien)
        sinhVien.HienThiThongTin();
    }
}
