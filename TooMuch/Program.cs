using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooMuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите имя");
            Console.WriteLine($"Привет, {Console.ReadLine()}!");

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Нельзя делить на 0");
            }
            else
            {
                Console.WriteLine("Результат: " + a/b);
            }

            Console.WriteLine("Задание 3");
          
            string s;
            int sled;
            Console.WriteLine("Введите букву: ");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                sled = ((int)c + 1);
                Console.WriteLine("Следующая буква: " + (char)sled);
            }
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите коэффициент a: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c: ");
            int c1 = int.Parse(Console.ReadLine());
            float rez = (-b1 + (b1^2 - 4*a1*c1)^0.5) / 2*a1;
        }
    }
}
