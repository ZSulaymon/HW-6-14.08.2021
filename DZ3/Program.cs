using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int.TryParse(Console.ReadLine(), out int massSize);
            int[] mass = new int[massSize];
            int i, n;
            for (i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Введите число: {i + 1}");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < mass.Length; j++)
            {
                Console.WriteLine(mass[j]);
            }
            Console.WriteLine("Введие размер нового массива:");
            int.TryParse(Console.ReadLine(), out int sizeCount);
            Console.WriteLine("Введие индекс массива:");
            int.TryParse(Console.ReadLine(), out int fromIndex);
            int[] count = new int[sizeCount + 1];

            for (n = fromIndex; n < mass.Length; n++)
            {
                count[n] = mass[n];
            }
            for (n = fromIndex; n < count.Length; n++)
            {
                if (count[n] == 0)
                {
                    count[n] = 1;
                }
                Console.WriteLine(count[n]);

            }
        }
    }
}
