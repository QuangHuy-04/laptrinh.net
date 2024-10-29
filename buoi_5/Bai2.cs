using System;

public class Bai2
{
    public void DemKyTuTrongChuoi()
    {
        Console.Write("nhap mot chuoi:");
        string a = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            char c = a[i];
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                count++;
            }
        }
        Console.WriteLine("Sso luong ky tu trong chuoi (khong bao gom khoang trang va dau cau) la: " + count);
    }
}
