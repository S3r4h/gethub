using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, result1;
            int result = 0;

            Console.WriteLine("Введите нижний порог прогрессии: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите верхний порог прогрессии: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите шаг арифметической прогрессии: ");
            c = Convert.ToInt32(Console.ReadLine());


            for (int i = a; i <= b; i += c)
            {
                result1 = i;
                result += result1;
                Console.WriteLine($"Сумма равна: {result}");
            }

            Console.ReadLine();
        }
    }
}
