// See https://aka.ms/new-console-template for more information
using System.Text;

int chose;
Random random = new Random();
int a = random.Next(1, 6);
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("nhap so :");
chose = Convert.ToInt32(Console.ReadLine());

if (a == chose)
{
    Console.WriteLine("ban thang！");
}
else
{
    Console.WriteLine("ban thua！");
}

Console.WriteLine("so computer chon:" + a);