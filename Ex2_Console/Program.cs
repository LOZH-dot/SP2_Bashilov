using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            Console.Write("Введите день недели (понедельник, вторник и так далее, регистр не учитывается): ");
            str = Console.ReadLine();

            str = str.ToUpper();

            switch (str)
            {
                case "ПОНЕДЕЛЬНИК":
                    Console.WriteLine("Врач принимает с 8:00 до 12:00");
                    break;
                case "ВТОРНИК":
                    Console.WriteLine("Врач принимает с 8:30 до 12:30");
                    break;
                case "СРЕДА":
                    Console.WriteLine("Врач принимает с 8:00 до 15:00");
                    break;
                case "ЧЕТВЕРГ":
                    Console.WriteLine("Врач принимает с 8:00 до 16:00");
                    break;
                case "ПЯТНИЦА":
                    Console.WriteLine("Врач принимает с 10:00 до 12:00");
                    break;
                case "СУББОТА":
                    Console.WriteLine("Врач принимает с 9:00 до 11:00");
                    break;
                case "ВОСКРЕСЕНЬЕ":
                    Console.WriteLine("Врач принимает с 8:00 до 17:30");
                    break;
                default:
                    Console.WriteLine("Такого дня недели не существует!");
                    break;
            }
        }
    }
}
