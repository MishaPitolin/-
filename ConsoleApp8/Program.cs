using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кооофицент a");
        double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коофицент b");
        double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коофицент с");
        double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Дискрименант равен:");
            Console.WriteLine(b * b - 4.0 * a * c);

            if (b * b - 4.0 * a * c < 0)
                Console.WriteLine("Корней нет");

            else if (b * b - a * c >= 0) 
                Console.WriteLine("Извлеките корень из дискрименанта и введите его");
            double D = double.Parse(Console.ReadLine());

            Console.WriteLine("Корни вашего уравнения");

            Console.WriteLine("X1 =");
            Console.WriteLine((-b + D)/(2.0 * a));
            Console.WriteLine("X2 =");
            Console.WriteLine((-b - D) / (2.0 * a));
        }
    }
}
