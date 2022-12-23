/*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.*/

using System;

namespace ConsoleApp1
{
    class Area
    {
        static void Main()
        {
            string vvod = "";
            bool result = false;
            Console.WriteLine("Для завершения вычислений: введите 'Закончить'");
            while (vvod != "Закончить")
            {
                Console.Write("Введите радиус Вашего круга, либо размеры сторон треугольника: ");
                vvod = Console.ReadLine();

                string[] area = vvod.Split(' ', '/', StringSplitOptions.RemoveEmptyEntries);

                foreach (string i in area)
                {
                    result = double.TryParse(i, out double num);
                }

                if (area.Length == 3 && result == true)
                {
                    Array.Sort(area);
                    double a = Convert.ToDouble(area[0]);
                    double b = Convert.ToDouble(area[1]);
                    double c = Convert.ToDouble(area[2]);
                    if (a != 0 && b != 0 && c != 0 && a + b >= c)
                    {
                        double p = (a + b + c) / 2.0;
                        double sr = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine(Math.Round(sr, 3));
                        if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                        {
                            Console.WriteLine("Данный треугольник - прямоугольный.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Данная фигура не является треугольником.");
                    }
                }

                else if (area.Length == 1 && result == true)
                {
                    double sr = Math.PI * (Math.Pow(Convert.ToDouble(area[0]), 2.0));
                    Console.WriteLine(Math.Round(sr, 3));
                }

                else if (vvod != "Закончить")
                {
                    Console.WriteLine("Неккоректное выражение.");
                }
            }
        }
    }
}