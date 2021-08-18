using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество массива:");
            int.TryParse(Console.ReadLine(), out int massSize);
            int[] mass = new int[massSize];
            //int [] oddNumbers = new int[];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Введите число: {i + 1}");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = mass.Length - 1; j >= 0; j--)
            {
                Console.WriteLine($"Инвертированный массив: {mass[j]}");
            }
        }
    }
}
