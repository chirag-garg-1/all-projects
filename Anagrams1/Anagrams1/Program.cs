using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams1
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string word2 = Console.ReadLine();
            
            if (word1.Length == word2.Length)
            {
                char[] ch1 = (word1.ToLower().ToCharArray());
                char[] ch2 = (word2.ToLower().ToCharArray());
            
                Array.Sort(ch1);
                Array.Sort(ch2);

                string s1 = new string(ch1);
                string s2 = new string(ch2);

                if(s1 == s2)
                {
                    Console.WriteLine("The words are Anagrams", word1, word2);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The words are not Anagrams", word1, word2);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The words are not Anagrams");
                Console.ReadLine();
            }
        }
    }
}
