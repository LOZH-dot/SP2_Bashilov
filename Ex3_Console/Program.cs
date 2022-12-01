using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            List<uint> result = new List<uint>();

            while (true)
            {
                try
                {
                    Console.Write("Введите начальное значение диапазона: ");
                    A = double.Parse(Console.ReadLine());

                    Console.Write("Введите конечное значение диапазона: ");
                    B = double.Parse(Console.ReadLine());

                    if (A > B) throw new Exception("Начальное значение диапазона должно быть меньше конечного!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Ожидается ввод числа! Попробуйте снова!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Введите числа, которые будут проверятся (для остановки введите stop): ");
            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    double number = 0;
                    string input = Console.ReadLine();
                    if (input == "stop") break;
                    number = double.Parse(input);

                    if ((int)number == number && number > 0 && number >= A && number <= B) result.Add((uint)number);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Ожидается ввод числа! Попробуйте снова!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write($"\nТолько положительные числа из диапазона от {A} до {B} (цикл for): ");

            for (int i = 0; i < result.Count; i++) Console.Write(result[i] + " ");

            Console.Write($"\nТолько положительные числа из диапазона от {A} до {B} (цикл while): ");

            int iterator = 0;
            while (iterator < result.Count)
            {
                Console.Write(result[iterator] + " ");
                iterator++;
            }

            Console.Write($"\nТолько положительные числа из диапазона от {A} до {B} (цикл do...while): ");

            iterator = 0;
            do {
                Console.Write(result[iterator] + " ");
                iterator++;
            } while (iterator < result.Count);

            Console.WriteLine();
        }
    }
}
