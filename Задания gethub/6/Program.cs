using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            var k = 0;
            var sm = 0;
            while (N > 0)
            {
                if (N % 2 == 0)
                {
                    k++;
                    sm += N;
                }

                N -= 1;
            }

            Console.WriteLine(k, sm);

            Console.ReadLine();
        }
    }
}
