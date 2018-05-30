using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_6
{
    class Program
    {
        static void Main(string[] args)
        { /*Написать программу, которая проверяет три отрезка на возможность создать прямоугольный треугольник. 
           * Длина отрезков вводится вручную.*/
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());


            if (((a + b) > c) && ((a - b) < c))
            {
                if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) || (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                     || (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)))
                    Console.WriteLine("The triangle is rectangular");
                else Console.WriteLine("The triangle is not rectangular"); 
            }
            else Console.WriteLine("The triangle is not exist"); 

            Console.ReadKey();
        }
    }
}
