using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocome to our bank :-");
            Console.WriteLine("1. check balance.");
            Console.WriteLine("2. transaction history.");
            Console.WriteLine("3. view past 1 year of history.");
            Console.WriteLine("4. check book allotment.");

            Console.Write("Please enter the number you want to check :- ");
            string checkstr = Console.ReadLine();
            int check = Convert.ToInt32(checkstr);

            if (check == 1)
            { 
            Console.WriteLine("Your balance is this :-");
            }

            else if(check == 2)
            {
                Console.WriteLine("transaction history is this :-");
            }

            else if (check == 3)
            {
                Console.WriteLine("Your 1 year past history is this :-");
            }

            else if (check == 4)
            {
                Console.WriteLine("your check book allotment is on the way :-");
            }

            Console.ReadLine();
        }
    }
}
