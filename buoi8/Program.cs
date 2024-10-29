using System;

public abstract class Product
{
    private string name;
    private decimal price;
    private int stock;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }
    public int Stock
    {
        get { return stock; }
        set { stock = value; }
    }

    public Product(string name, decimal price, int stock)
    {
        this.name = name;
        this.price = price;
        this.stock = stock;
    }

    // Phương thức trừu tượng để hiển thị thông tin chi tiết sản phẩm
    public abstract void DisplayProductInfo();

    // Phương thức trừu tượng để áp dụng giảm giá
    public abstract void ApplyDiscount(decimal percentage);
}

public interface ISellable
{
    void Sell(int quantity); // Bán sản phẩm, giảm số lượng tồn kho
    bool IsInStock(); // Kiểm tra sản phẩm có còn trong kho không
}

public class MobilePhone : Product, ISellable
{
    private string brand;
    private string model;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public MobilePhone(string name, decimal price, int stock, string brand, string model)
        : base(name, price, stock)
    {
        this.brand = brand;
        this.model = model;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"MobilePhone: {Name}, Brand: {Brand}, Model: {Model}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Insufficient stock for {Name}. Only {Stock} left.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

public class Laptop : Product, ISellable
{
    private string brand;
    private string cpu;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public string CPU
    {
        get { return cpu; }
        set { cpu = value; }
    }

    public Laptop(string name, decimal price, int stock, string brand, string cpu)
        : base(name, price, stock)
    {
        this.brand = brand;
        this.cpu = cpu;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop: {Name}, Brand: {Brand}, CPU: {CPU}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * percentage / 100;
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Insufficient stock for {Name}. Only {Stock} left.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

public class Accessory : Product, ISellable
{
    private string type;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public Accessory(string name, decimal price, int stock, string type)
        : base(name, price, stock)
    {
        this.type = type;
    }

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
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Insufficient stock for {Name}. Only {Stock} left.");
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
        // Tạo các đối tượng sản phẩm
        MobilePhone phone = new MobilePhone("iPhone 13", 1000, 10, "Apple", "13 Pro Max");
        Laptop laptop = new Laptop("Dell XPS", 1500, 5, "Dell", "Intel i7");
        Accessory accessory = new Accessory("Mouse", 50, 20, "Wireless");

        // Hiển thị thông tin sản phẩm
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        // Áp dụng giảm giá cho sản phẩm
        phone.ApplyDiscount(10); // Giảm 10%
        accessory.ApplyDiscount(20); // Giảm 20%

        Console.WriteLine("\nSau khi giảm giá:");
        phone.DisplayProductInfo();
        accessory.DisplayProductInfo();

        // Bán một số sản phẩm
        phone.Sell(3);
        laptop.Sell(2);
        accessory.Sell(5);

        Console.WriteLine("\nTình trạng kho sau khi bán:");
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        // Kiểm tra xem sản phẩm có còn trong kho hay không
        Console.WriteLine($"\n{phone.Name} in stock: {phone.IsInStock()}");
        Console.WriteLine($"{laptop.Name} in stock: {laptop.IsInStock()}");
        Console.WriteLine($"{accessory.Name} in stock: {accessory.IsInStock()}");
    }
}
