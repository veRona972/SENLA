using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_3
{
    class Program
    {
        static void Main(string[] args)
        {/*Необходимо написать программу, которая проверяет слово на "палиндромность". Слово для проверки вводится вручную 
          * во время выполнения программы. */
            string word = Console.ReadLine();
            int k = 0;

            for (int i = 0; i < (word.Length)/2; i++)
            {
                if (word[i] == word[word.Length - (i + 1)])
                 k++; 
            } 

           if ((word.Length)/2 == k)
                Console.WriteLine(word + " " + "палиндром");
            else Console.WriteLine(word + "  " + "не палиндром");

            Console.ReadKey();

            
        }
    }
}
