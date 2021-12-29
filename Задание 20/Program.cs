using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        // Делегаты
        delegate double Circle(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello инженер! Введите радиус окружности в сантиметрах");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"При радиусе окружности R={r} см");
            Circle circle = new Circle(CircumFerence);
            circle += AreaCircle;
            circle += BallVolume;
            circle?.Invoke(r);
            Console.ReadKey();
        }


        // длина окружности 
        static double CircumFerence(double r)
        {
            double circumFerence = 2 * Math.PI * r;
            Console.WriteLine($"\nДлина окружности L={String.Format("{0:f}", circumFerence)} см");
            return circumFerence;
        }

        // площадь круга
        static double AreaCircle(double r)
        {
            double areaCircle = Math.PI * r * r;
            Console.WriteLine($"\nПлощадь круга S={String.Format("{0:f}", areaCircle)} см2");
            return areaCircle;
        }

        //объем шара
        static double BallVolume(double r)
        {
            double ballVolume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"\nОбъем шара S={String.Format("{0:f}", ballVolume)} см3");
            return ballVolume;
        }

    }
}
