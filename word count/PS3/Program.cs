using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method 1 :-
            Console.WriteLine("Enter the line");
            string line = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"the number of words in line : {count + 1}");


            // Method 2 :-
            Console.WriteLine("Enter the sentense :");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            int wordscount = words.Length;

            Console.WriteLine("the no of words in the sentence is :" + wordscount);

            Console.ReadLine();

        }
    }
}
