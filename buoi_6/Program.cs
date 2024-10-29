using System;
using System.Collections.Generic;
using System.Linq;

class buoi_6
{
    public class Product
    {
        public string Name { get; set; }
        public float Gia { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }

        public Product() { }
        public Product(string name, float gia, int soluong, string mota)
        {
            this.Name = name;
            this.Gia = gia;
            this.SoLuong = soluong;
            this.MoTa = mota;
        }
        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Tên sản phẩm: {Name}, Giá: {Gia}, Số lượng: {SoLuong}, Mô tả: {MoTa}");
        }
    }

    public class Electronic : Product
    {
        public int BaoHanh { get; set; }

        public Electronic(string name, float gia, int soluong, string mota, int baohanh)
            : base(name, gia, soluong, mota)
        {
            this.BaoHanh = baohanh;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Bảo hành: {BaoHanh} tháng");
        }
    }

    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Clothing(string name, float gia, int soluong, string mota, string size, string color)
            : base(name, gia, soluong, mota)
        {
            this.Size = size;
            this.Color = color;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Kích thước: {Size}");
            Console.WriteLine($"Màu sắc: {Color}");
        }
    }

    public class Food : Product
    {
        public string ExpirationDate { get; set; }

        public Food(string name, float gia, int soluong, string mota, string expirationDate)
            : base(name, gia, soluong, mota)
        {
            this.ExpirationDate = expirationDate;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ngày hết hạn: {ExpirationDate}");
        }
    }

    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void ThemSanPham(Product product)
        {
            products.Add(product);
        }

        public void XoaSanPham(Product product)
        {
            products.Remove(product);
        }

        public void HienThiDanhSachSanPham()
        {
            Console.WriteLine("Danh sách sản phẩm trong giỏ hàng:");
            foreach (var product in products)
            {
                product.HienThiThongTin();
                Console.WriteLine(); // Thêm dòng trống giữa các sản phẩm
            }
        }

        public float TinhTongGiaTri()
        {
            return products.Sum(p => p.Gia * p.SoLuong);
        }
    }

    static void Main(string[] args)
    {
        // Danh sách sản phẩm có sẵn
        List<Product> availableProducts = new List<Product>
        {
            new Electronic("Laptop", 1500, 1, "Laptop cao cấp", 24),
            new Clothing("Áo phông", 2000, 2, "Áo phông VIP", "Size S", "Đen"),
            new Food("Cơm hộp", 10, 1, "Bình dân", "19/09/2024")
        };

        // Tạo giỏ hàng
        ShoppingCart cart = new ShoppingCart();

        while (true)
        {
            Console.WriteLine("Danh sách sản phẩm có sẵn:");
            for (int i = 0; i < availableProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableProducts[i].Name} - {availableProducts[i].Gia} VND");
            }
            Console.WriteLine("Chọn số sản phẩm để thêm vào giỏ hàng (hoặc nhập 'q' để thoát):");

            string input = Console.ReadLine();
            if (input.ToLower() == "q")
                break;

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= availableProducts.Count)
            {
                Product selectedProduct = availableProducts[choice - 1];
                cart.ThemSanPham(selectedProduct);
                Console.WriteLine("Sản phẩm đã được thêm vào giỏ hàng.");
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }

            Console.WriteLine("\nGiỏ hàng hiện tại:");
            cart.HienThiDanhSachSanPham();

            float tongGiaTri = cart.TinhTongGiaTri();
            Console.WriteLine($"Tổng giá trị đơn hàng: {tongGiaTri} VND");
            Console.WriteLine();
        }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Linq;

//class buoi_6
//{
//    public class Product
//    {
//        public string Name { get; set; }
//        public float Gia { get; set; }
//        public int SoLuong { get; set; }
//        public string MoTa { get; set; }

//        public Product() { }
//        public Product(string name, float gia, int soluong, string mota)
//        {
//            this.Name = name;
//            this.Gia = gia;
//            this.SoLuong = soluong;
//            this.MoTa = mota;
//        }
//        public virtual void HienThiThongTin()
//        {
//            Console.WriteLine($"Tên sản phẩm: {Name}, Giá: {Gia}, Số lượng: {SoLuong}, Mô tả: {MoTa}");
//        }
//    }

//    public class Electronic : Product
//    {
//        public int BaoHanh { get; set; }

//        public Electronic(string name, float gia, int soluong, string mota, int baohanh)
//            : base(name, gia, soluong, mota)
//        {
//            this.BaoHanh = baohanh;
//        }

//        public override void HienThiThongTin()
//        {
//            base.HienThiThongTin();
//            Console.WriteLine($"Bảo hành: {BaoHanh} tháng");
//        }
//    }

//    public class Clothing : Product
//    {
//        public string Size { get; set; }
//        public string Color { get; set; }

//        public Clothing(string name, float gia, int soluong, string mota, string size, string color)
//            : base(name, gia, soluong, mota)
//        {
//            this.Size = size;
//            this.Color = color;
//        }

//        public override void HienThiThongTin()
//        {
//            base.HienThiThongTin();
//            Console.WriteLine($"Kích thước: {Size}");
//            Console.WriteLine($"Màu sắc: {Color}");
//        }
//    }

//    public class Food : Product
//    {
//        public string ExpirationDate { get; set; }

//        public Food(string name, float gia, int soluong, string mota, string expirationDate)
//            : base(name, gia, soluong, mota)
//        {
//            this.ExpirationDate = expirationDate;
//        }

//        public override void HienThiThongTin()
//        {
//            base.HienThiThongTin();
//            Console.WriteLine($"Ngày hết hạn: {ExpirationDate}");
//        }
//    }

//    public class ShoppingCart
//    {
//        private List<Product> products = new List<Product>();

//        public void ThemSanPham(Product product)
//        {
//            products.Add(product);
//        }

//        public void XoaSanPham(Product product)
//        {
//            products.Remove(product);
//        }

//        public void HienThiDanhSachSanPham()
//        {
//            foreach (var product in products)
//            {
//                product.HienThiThongTin();
//                Console.WriteLine(); // Thêm dòng trống giữa các sản phẩm
//            }
//        }

//        public float TinhTongGiaTri()
//        {
//            return products.Sum(p => p.Gia * p.SoLuong);
//        }
//    }

//    static void Main(string[] args)
//    {
//        // Tạo các sản phẩm
//        Electronic laptop = new Electronic("Laptop", 1500, 1, "Laptop cao cấp", 24);
//        Clothing ao = new Clothing("Áo phông", 2000, 2, "Áo phông VIP", "Size S", "Đen");
//        Food com = new Food("Cơm hộp", 10, 1, "Bình dân", "19/09/2024");

//        // Tạo giỏ hàng
//        ShoppingCart cart = new ShoppingCart();

//        // Thêm sản phẩm vào giỏ hàng
//        cart.ThemSanPham(laptop);
//        cart.ThemSanPham(ao);
//        cart.ThemSanPham(com);

//        // Hiển thị danh sách sản phẩm trong giỏ hàng
//        Console.WriteLine("Danh sách sản phẩm trong giỏ hàng:");
//        cart.HienThiDanhSachSanPham();

//        // Tính tổng giá trị đơn hàng
//        float tongGiaTri = cart.TinhTongGiaTri();
//        Console.WriteLine($"Tổng giá trị đơn hàng: {tongGiaTri} VND");
//    }
//}
