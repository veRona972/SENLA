using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_5
{
    class Program
    {
        static void Main(string[] args)
        {/*Создать программу, которая подсчитывает сколько раз употребляется слово в тексте (без учета регистра) . 
          * Текст и слово вводится вручную.*/
            string line = Console.ReadLine();
            string line_ = line.ToLower();
            string word = Console.ReadLine();
            int k = 0;
            string[] words = line_.Split(' ');

            foreach (var a in words)
            {
                if (a == word) k++;
            }

            Console.WriteLine("Слово "+ word + " встречается " + k + " раз");
            Console.ReadKey();
        }
    }
}
