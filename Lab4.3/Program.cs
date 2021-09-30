using System;

namespace Lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.");
            Console.WriteLine("Введите а");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            float b = Convert.ToInt32(Console.ReadLine());
            double Middle = (a + b) / 2;
            Console.WriteLine($"Среднее арифметическое:{Middle}");
        }
    }
}
