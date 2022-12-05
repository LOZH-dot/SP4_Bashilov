using System;

namespace Ex2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите положительное четное целое число: ");
                    n = int.Parse(Console.ReadLine());

                    if (n < 1) throw new Exception("Число должно быть больше или равно 1!");
                    if (n % 2 != 0) throw new Exception("Число должно быть четным!");
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

            ShowPicture(0, n);
        }

        static void ShowPicture(int spaces, int n)
        {
            if (spaces == n) return;

            int space = spaces;
            for (int i = 0; i < space; i++)
                Console.Write(" ");
            for (int i = space; i < n; i++)
                Console.Write("*");
            Console.WriteLine();

            ShowPicture(spaces + 1, n);
        }
    }
}
