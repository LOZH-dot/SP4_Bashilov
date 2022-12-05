using System;

namespace Ex1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;

            while (true)
            {
                try
                {
                    Console.Write("Введите целое число для вычисления n-го члена последовательности: ");
                    n = int.Parse(Console.ReadLine());

                    if (n < 1) throw new Exception("Число должно быть больше или равно 1!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Ожидается ввод целого числа!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"\nРезультат вычисления последовательности: {Calculate(5.0, n)}");
        }

        static double Calculate(double b, int n)
        {
            if (n <= 1) return b;

            return Calculate(b / ((n * n) + n + 1), n - 1);
        }
    }
}
