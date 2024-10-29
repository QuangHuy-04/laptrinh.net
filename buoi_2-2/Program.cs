Console.WriteLine("nhap so luong:");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Nhap cac phan tu cua mang: ");
for (int i = 0; i < n; i++)
{
    Console.Write("phan tu thu " + (i + 1)+ " :");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine("phan tu lon nhat trong mang la " + max);
