using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for given rows :-
            for (int i = 5; i>=1; i--)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            // for input the no of rows :-
            Console.Write("Enter Number of Rows :");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
                Console.ReadLine();
        }
    }
}
