using System;

namespace Zadacha_discord
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int s = 0;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max <= array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            Array.Reverse(array);
            foreach (int x in array)
                Console.Write(x + " ");
            
        }
    }
}
