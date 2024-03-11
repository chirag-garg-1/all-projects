using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Ente the no of digits you want enter :");
            int Digits = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers :");

            for (int i = 0; i <Digits ; i++)
            {
               int num = int.Parse(Console.ReadLine());
               numbers.Add(num);
            }

            numbers.Sort();

            if (numbers[Digits-1] != numbers[Digits-2])
            { 
            Console.WriteLine( numbers[Digits-2]);

            }
            else if (numbers[Digits - 1] == numbers[Digits - 2]) 
            {
                Console.WriteLine(numbers[Digits - 3]);
            }

            Console.ReadLine();
        }
    }
}
