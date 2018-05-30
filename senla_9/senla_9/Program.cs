using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_9
{
    class Program
    {
        static void Main(string[] args)
        {/*Написать программу выводящую на экран все четные числа и их сумму из последовательности от 0 до N.
          * N вводится вручную. */
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[N+1];
            int sum = 0;

            for (int i = 0; i <= N; i++)
            {
                mass[i] = i;
               
                if (i!= 0 && i % 2 == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
               
            }
            Console.WriteLine("\nSum is " + sum);
                Console.ReadKey();
        }
    }
}
