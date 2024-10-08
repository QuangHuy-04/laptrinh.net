public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    // Phương thức trừu tượng để hiển thị thông tin sản phẩm
    public abstract void DisplayProductInfo();

    // Phương thức trừu tượng để áp dụng giảm giá
    public abstract void ApplyDiscount(decimal percentage);
}
public interface ISellable
{
    void Sell(int quantity);
    bool IsInStock();
}
public class MobilePhone : Product, ISellable
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Mobile Phone: {Name}, Brand: {Brand}, Model: {Model}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} MobilePhone(s) sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Laptop : Product, ISellable
{
    public string Brand { get; set; }
    public string Processor { get; set; }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop: {Name}, Brand: {Brand}, Processor: {Processor}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} Laptop(s) sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Accessory : Product, ISellable
{
    public string Type { get; set; }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory: {Name}, Type: {Type}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} Accessory(s) sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Khởi tạo các đối tượng
        MobilePhone phone = new MobilePhone()
        {
            Name = "iPhone 13",
            Brand = "Apple",
            Model = "Pro Max",
            Price = 999.99m,
            Stock = 10
        };

        Laptop laptop = new Laptop()
        {
            Name = "Dell XPS 15",
            Brand = "Dell",
            Processor = "Intel i7",
            Price = 1499.99m,
            Stock = 5
        };

        Accessory accessory = new Accessory()
        {
            Name = "Wireless Mouse",
            Type = "Mouse",
            Price = 25.99m,
            Stock = 50
        };

        // Hiển thị thông tin sản phẩm
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        // Thực hiện bán hàng
        phone.Sell(2);
        laptop.Sell(1);
        accessory.Sell(10);

        // Kiểm tra tồn kho
        Console.WriteLine($"Phone in stock: {phone.IsInStock()}");
        Console.WriteLine($"Laptop in stock: {laptop.IsInStock()}");
        Console.WriteLine($"Accessory in stock: {accessory.IsInStock()}");

        // Áp dụng giảm giá
        phone.ApplyDiscount(10);  // Giảm 10%
        laptop.ApplyDiscount(15); // Giảm 15%

        // Hiển thị thông tin sau khi giảm giá
        Console.WriteLine("After discount:");
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
    }
}

