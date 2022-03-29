using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.   Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:метод, определяющий длину окружности по заданному радиусу;метод, определяющий площадь круга по заданному радиусу;метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.");
            Console.Write("Введите радиус круга r= ");
            double r = Convert.ToDouble(Console.ReadLine());
            double lenghtCircle = Circle.GetLenght(r);
            double squareCircle = Circle.GetSquare(r);
            Console.WriteLine($"Длина окружности {lenghtCircle} \n Площадь круга {squareCircle}");
            Console.Write("Введите координату х точки ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату у точки ");
            double y = Convert.ToDouble(Console.ReadLine());
            double point = Circle.GetPoint(r, x, y);
            if (point==1)
            {
                Console.WriteLine("точка в круге");
            }
            else
            {
                Console.WriteLine("точка вне круга");
            }
            Console.ReadKey();

        }
    }
}
