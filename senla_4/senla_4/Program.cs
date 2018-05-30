using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senla_4
{
    class Program
    {
        static void Main(string[] args)
        { /*Создать программу, которая будет подсчитывать количество слов в предложении и выводить их в отсортированном виде.
           * Предложение вводится вручную. (Разделители пробел (“ ”) и запятая (“,”)). */

            int k = 0;
            string text = Console.ReadLine();
            char[] a = { ' ', ',' }; 
            string[] words = text.Split(a);
            List<string> strings = new List<string>();

            foreach (var word in words)
            {   k++; 
                strings.Add(word);
            }
           
            Console.WriteLine("Number of words - " + k);
            strings.Sort();
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}
