using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
public class baitap 
{
    public void Bai1()
    {
        //ArrayList là một danh sách động, lưu trữ các phần tử theo kiểu mảng nhưng có khả năng thay đổi kích thước.

        ArrayList array = new ArrayList();
        int n;
        Console.WriteLine("nhap so luong phan tu:");
        n = int.Parse(Console.ReadLine());
        //n=Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("nhap so nguyen thu" + (i + 1) + ":");
            int a = int.Parse(Console.ReadLine());
            array.Add(a);
        }
        array.Sort();
        Console.WriteLine("/ndanh sach cac so nguyen theo thu tu tang dan: ");
        //foreach (int a in array)
        //{
        //    Console.WriteLine(a);
        //}
        for (int i = 0; i < n; i++)
        {
            int a = (int)array[i];  // Ép kiểu về int
            Console.WriteLine(a);   // Hiển thị giá trị        }
        }
    }
    public void Bai2()
    {
        //Hashtable là một cấu trúc dữ liệu lưu trữ các cặp khóa(key) và giá trị(value), trong đó mỗi khóa là duy nhất.
        Hashtable people = new Hashtable();
        string name;
        int age;

        Console.WriteLine("Nhập số lượng người: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhập tên người thứ " + (i + 1) + ": ");
            name = Console.ReadLine();
            Console.Write("Nhập tuổi của " + name + ": ");
            age = int.Parse(Console.ReadLine());

            // Thêm cặp tên - tuổi vào Hashtable
            people.Add(name, age);
        }

        // In danh sách tên và tuổi
        Console.WriteLine("\nDanh sách tên và tuổi:");
        foreach (DictionaryEntry entry in people)
        {
            Console.WriteLine("Tên: {0}, Tuổi: {1}", entry.Key, entry.Value);
        }

        // Nếu muốn duyệt lại theo tên
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhập tên để lấy tuổi: ");
            name = Console.ReadLine();
            if (people.ContainsKey(name))
            {
                age = (int)people[name];  // Lấy tuổi dựa trên tên
                Console.WriteLine("Tuổi của " + name + " là: " + age);
            }
            else
            {
                Console.WriteLine("Tên " + name + " không tồn tại.");
            }
        }
    }
    public void bai3()
    {
        //Dictionary cũng là một cấu trúc dữ liệu lưu trữ các cặp khóa và giá trị giống như Hashtable, nhưng nó được thiết kế để làm việc với kiểu dữ liệu mạnh mẽ hơn thông qua generic.
        Dictionary<string, int> students = new Dictionary<string, int>();
        string name;
        int score;

        Console.WriteLine("Nhập số lượng học sinh: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập tên và điểm của n học sinh
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhập tên học sinh thứ " + (i + 1) + ": ");
            name = Console.ReadLine();

            Console.Write("Nhập điểm của " + name + ": ");
            score = int.Parse(Console.ReadLine());

            // Thêm tên và điểm của học sinh vào Dictionary
            students.Add(name, score);
        }

        // In danh sách tên và điểm của học sinh
        Console.WriteLine("\nDanh sách học sinh và điểm:");
        foreach (KeyValuePair<string, int> student in students)
        {
            Console.WriteLine("Tên: {0}, Điểm: {1}", student.Key, student.Value);
        }
    }
}
