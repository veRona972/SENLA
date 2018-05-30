using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_2
{
    class Program
    {
        static void Main(string[] args)
        { /*Создать программу, которая будет вычислять и выводить на экран сумму, разность, НОК и НОД двух целых чисел, 
           * введенных пользователем. Если пользователь некорректно введёт хотя бы одно из чисел, то сообщать об ошибке.*/
            int a; 
            int b; 

            while (!int.TryParse(Console.ReadLine(), out a))
            {
               Console.WriteLine("Введите целое число a");
            }
          
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введите целое число b");
            }
            int sum = a + b;
            int dif = a - b;
            int nok;
            int nod;

            for (int i = 0; i < (a * b + 1); i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                     nok = i;
                     if (i != 0)
                     {
                         Console.WriteLine("НОD = " + nok);
                         break;
                     }
                }
            }

            for (int i = 2; i < a ; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    nod = i;
                    Console.WriteLine("НОК = " + nod);
  
                }
            } 
              

            Console.WriteLine("Cумма = " + sum + "\n" + "Разность " + dif + "\n");
         
            Console.ReadKey();
        }
    }
}
