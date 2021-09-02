using System;

namespace ConsoleApp1
{
    class Program
    {
        static float zero(int a, int b)
        {
            try
            {
                return (float)a/b;
            }
            catch
            {
                Console.WriteLine("Делить на ноль нельзя!");
                return 1;
            }
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(zero(a,b));

            // int = 4 байта;
            // float = 4 байта;
        }
    }
}
