using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace palindrome1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence :-");
            string sentence = Console.ReadLine();

            char[] ch1 = sentence.ToCharArray();

            Array.Reverse(ch1);

            string word1 = new string(ch1);

            if (word1 == sentence) 
            {
                Console.WriteLine("the numbers are palindrome :-");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the numbers are not palindrome :-");
                Console.ReadLine();
            }
        }
    }
}
