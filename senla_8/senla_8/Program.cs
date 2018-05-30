using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_8
{
    class Program
    {
        static void Main(string[] args)
        { /*Написать программу, которая в последовательности от 0 до N, находит все числа-палиндромы (зеркальное значение
           * равно оригинальному). Длина последовательности вводится вручную и не должна превышать 100. */

            int N = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[N];

            for (int i = 0; i < N; i++)
            {
                mass[i] = i;
            }

            for (int i = 1; i < N; i ++)
            {
                double k = i / 10;
                if (Math.Truncate(k) == 0)
                { Console.WriteLine(i); }
            }

            for (int i = 0; i < N; i+=11)
            {
                Console.WriteLine(i);
            } 


            Console.ReadKey();
        }
    }
}
