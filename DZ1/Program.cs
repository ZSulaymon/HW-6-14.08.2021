using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество массива");
            int.TryParse(Console.ReadLine(), out int massSize);
            int[] mass = new int[massSize];
            //int [] oddNumbers = new int[];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Введите число: {i + 1}");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minValue = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < minValue)
                {
                    minValue = mass[i];
                }
            }
            int maxValue = mass[0];
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[j] > maxValue)
                {
                    maxValue = mass[j];
                }
            }
            var sumAvg = 0.0;
            var total = 0.0;
            for (int j = 0; j < mass.Length; j++)
            {
                total += mass[j];
                sumAvg = total / massSize;
            }
            Console.WriteLine($"Мин число: {minValue}");
            Console.WriteLine($"Макс число: {maxValue}");
            Console.WriteLine($"Общая сумма: {total}");
            Console.WriteLine($"Сред арифмитическое число: {sumAvg}");
            bool inc = false;
            var message = "";
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[j] % 2 == 1)  
                {
                    Console.WriteLine($"Вывести нечетные числа: {mass[j]}"); inc = true;
                }
                else 
                {
                    message = "Всё числа четные!";
                }
            }
            if (!inc)
            {
                Console.WriteLine($"{message}");
            }
        }

    }

}
