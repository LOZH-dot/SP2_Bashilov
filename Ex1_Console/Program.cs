using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x0, y0;

            double x1 = 0.0, x2 = 70.0, x3 = 70.0;
            double y1 = 0.0, y2 = 0.0, y3 = 70.0;

            double a, b, c;

            while (true)
            {
                try
                {
                    Console.Write("Введите первую координату точки (x): ");
                    x0 = double.Parse(Console.ReadLine());

                    Console.Write("Введите вторую координату точки (y): ");
                    y0 = double.Parse(Console.ReadLine());
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

            a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

            if (a == 0.0 || b == 0.0 || c == 0.0)
                Console.WriteLine($"Точка ({x0}, {y0}) находится на границе");
            else if (a > 0 && b > 0 && c > 0)
                Console.WriteLine($"Точка ({x0}, {y0}) находится внутри");
            else
                Console.WriteLine($"Точка ({x0}, {y0}) находится снаружи");
        }
    }
}
