using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Введите 3 числа, чтобы определить наименьшее из них:");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            m = x < y ? x < z ? x : z : y < z ? y : z;
            Console.WriteLine($"min = {m}");
        }
    }
}
