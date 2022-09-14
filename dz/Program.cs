using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Число e");
            double chislo = (Math.E);
            Console.WriteLine(Math.Round(chislo, 1));

            Console.WriteLine("Задание 2. Числа 50, 10");
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine("Задание 3. 4 случайных числа");
            Random rnd = new Random();  
            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next());

            Console.WriteLine("Задание 4. Число больше на 10");
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + 10);

            Console.WriteLine("Задание 5. Периметр квадрата");
            Console.WriteLine("Введите число(сторону квадрата): ");
            int storona = int.Parse(Console.ReadLine());
            Console.WriteLine(storona*4);

            Console.WriteLine("Задание 6. Длина и площадь окружности");
            Console.WriteLine("Введите радиус окружности: ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности: " + 2 * Math.PI * radius + " | Площадь окружности: " + Math.PI * Math.Pow(radius, 2));

            Console.WriteLine("Задание 7. Косинус");
            Console.WriteLine("Введите угол: ");
            double cosinus = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Cos(cosinus));

            Console.WriteLine("Задание 8. Периметр трапеции");
          
            Console.WriteLine("Введите длину первого основания: ");
            int osn1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второго основания: ");
            int osn2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину высоты: ");
            int visota = int.Parse(Console.ReadLine());
            double storoni = Math.Sqrt(Math.Pow(((Math.Abs(osn1 - osn2))/2), 2) + Math.Pow(visota, 2));
            Console.WriteLine(2 * storoni + osn1 + osn2); ////

            Console.WriteLine("Задание 9. Магазин");
            int konfeti = 850;
            int pechenie = 500;
            int yabloki = 150;
            Console.WriteLine("Сколько кг конфет купили?");
            float kgkonf = float.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг печенья купили?");
            float kgpech = float.Parse(Console.ReadLine());    
            Console.WriteLine("Сколько кг яблок купили?");
            float kgyablok = float.Parse(Console.ReadLine());
            Console.WriteLine("Стоимость покупки: " + kgkonf*konfeti + kgpech*pechenie + kgyablok*yabloki);

            Console.WriteLine("Задание 10. Три строки");
            Console.WriteLine("Мир " + "Труд " + "Май");
            Console.WriteLine("Мир");
            Console.WriteLine("      Труд");
            Console.WriteLine("             Май");
                
            Console.WriteLine("Задание 11. Три строки");

        }
    }
}
