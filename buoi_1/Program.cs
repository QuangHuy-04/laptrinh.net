namespace buoi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** ");
            for (int i = 0; i < 7; i++)
            {
                if (i == 3)
                    Console.WriteLine("*****");
                else
                    Console.WriteLine("*   *");
            }
        }
    }
}