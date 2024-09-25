using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Bài tập 1: Sử dụng List
        Console.WriteLine("Bai 1: Nhap danh sach cac so nguyen.");
        List<int> numbers = new List<int>();
        Console.Write("Nhap so luong so nguyen: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Nhap so nguyen thu {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        numbers.Sort();
        Console.WriteLine("Danh sach cac so nguyen theo thu tu tang dan: " + string.Join(", ", numbers));

        // Bài tập 2: Sử dụng Hashtable
        Console.WriteLine("\nBai 2: Nhap ten va tuoi cua nhieu nguoi.");
        Hashtable hashtable = new Hashtable();

        Console.Write("Nhap so luong nguoi: ");
        int numPeople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numPeople; i++)
        {
            Console.Write($"Nhap ten nguoi thu {i + 1}: ");
            string name = Console.ReadLine();
            Console.Write($"Nhap tuoi cua {name}: ");
            int age = int.Parse(Console.ReadLine());
            hashtable[name] = age;
        }

        Console.WriteLine("Danh sach ten va tuoi:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
        }

        // Bài tập 3: Sử dụng Dictionary
        Console.WriteLine("\nBai 3: Nhap ten va điem cua hoc sinh.");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        Console.Write("Nhap so luong hoc sinh: ");
        int numStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Nhap ten hoc sinh thu {i + 1}: ");
            string studentName = Console.ReadLine();
            Console.Write($"Nhap điem cua {studentName}: ");
            int score = int.Parse(Console.ReadLine());
            dictionary[studentName] = score;
        }

        Console.WriteLine("Danh sach hoc sinh va điem cua ho:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Ten: {kvp.Key}, Điem: {kvp.Value}");
        }
    }
}

