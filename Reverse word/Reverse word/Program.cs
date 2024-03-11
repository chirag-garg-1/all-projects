using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence :-");
            string sentence = Console.ReadLine();

            string[] strArray = sentence.Split(' ');

            string[] reverseArray = new string[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                char[] letter = strArray[i].ToCharArray();

                Array.Reverse(letter);

                reverseArray[i] = new string(letter);
            }
            string reverseword = string.Join(" " , reverseArray);
            Console.WriteLine(reverseword);
            Console.ReadLine();
        }
    }
}
