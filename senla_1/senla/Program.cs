using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
                {
                     Console.WriteLine("Введите целое число a");
                }

                if (a % 2 == 0)
                { Console.WriteLine("Число " + a + " является четным"); }
                else
                { Console.WriteLine("Число " + a + " является нечетным"); }

                Random r = new Random();
                int n = r.Next(2, a - 1); 
                double c = (double)n; 
                double d = (double)a;

                if ((Math.Pow(c, d)) % d != c % d)
                {Console.WriteLine("Число " + a + " является coставным") ;}
                else
                { Console.WriteLine("Число " + a + " является простым"); }
              
                    Console.ReadKey();

        }
    }
}
