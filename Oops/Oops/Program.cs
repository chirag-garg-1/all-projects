using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];

            //Console.WriteLine(age[3]);

            //int[] A = new int[2];

            //A[0] = 1;
            //A[1] = 2;
            //A[2] = 3;
            // before intialisation the array :-
            for (int i = 0; i <= Numbers.Length-1; i++) 
            {
                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
            }

            // after intialisation the array :-

            Numbers[0] = 10;
            Numbers[1] = 30;
            Numbers[2] = 20;

            for (int i = 0; i <= Numbers.Length - 1; i++)
            {
                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
            }


            Console.ReadLine();

        }
    }   
}
