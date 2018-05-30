using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_10
{
    class Program
    {
        static void Main(string[] args)
        { /*Написать программу, составляющую всевозможные комбинации 3-х значных чисел из 3-х введенных пользователем цифр. 
           * Цифры вводятся вручную.*/

            string[] a_s = new string[3];
           
            for (int i = 0; i < 3; i++)
            { a_s[i] = Console.ReadLine(); }

            int m = 3, n = 3;
            for (int i = 0; i < Math.Pow(m, n); i++)
            {
                string s = "";
                int ii = i;
                for (int j = 0; j < n; j++)
                {
                    s = a_s[ii % m] + s;
                    ii /= m;
                }
                Console.WriteLine(s);
            }


           
 
            Console.ReadKey();
        }
    }
}
