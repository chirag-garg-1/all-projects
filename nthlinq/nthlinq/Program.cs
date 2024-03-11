using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nthlinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the list of number seprated by commas :");
            string numbers = Console.ReadLine();

            List<int> Listnumbers = numbers.Split(',').Select(int.Parse).ToList();

            Console.WriteLine("Enter the index :");
            int n = int.Parse(Console.ReadLine());

            /*var QuerySyntax = Listnumbers.SingleOrDefault();*/
            var q = Listnumbers.FirstOrDefault();

/*                Console.WriteLine($"The element at index {n} is: {QuerySyntax}");
*/            
                Console.WriteLine($"Index {q} is out of range for the given list.");
            
        }
    }
}
