using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("третье число: ");
            double c = Convert.ToDouble(Console.ReadLine());

            var min = a < b ? a : b;
            min = min < c ? min : c;

            Console.WriteLine($"Минимальное из чисел {a}, {b}, {c} равно {min}");
            Console.ReadLine();
        }
    }
}
