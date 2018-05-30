using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_7
{
    class Program
    {
        static void Main(string[] args)
        {/*Написать программу, которая рандомно генерирует массив 2-ух значных чисел длины N (вводится вручную) и 
          * выводит наименьшее и наибольшее число из списка. */

            Random r = new Random(); 
            int N = Convert.ToInt32(Console.ReadLine());
            double[] mass = new double[N];

            for (int i = 0; i < N; i++)
            {
                mass[i] = r.Next(10,99);
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine("\n Minimum element " + mass.Min() + "\n Maximum element " + mass.Max());
            Console.ReadKey();
        }
    }
}
