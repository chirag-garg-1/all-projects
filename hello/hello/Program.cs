using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.Write("good morning" + name);
        }

        static float average(int a, int b, int c)
        { 
            float sum = a + b + c;
            return sum / 3;

        }


        static void Main(string[] args)
        {
            /*string hello = "hello world my name is harry ";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(string.Concat(hello , "you  are nice"));*/

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"yourn name is {name}, you will get the {candies} candies");



            // if else statements :-
            //Console.WriteLine("Enter your age :");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //bool isbanned = true;

            //if (age < 2 && isbanned )
            //{
            //    Console.WriteLine("you are just born or banned");
            //}

            //else if (age < 10 && isbanned)
            //{
            //    Console.WriteLine("complete your high school  or may be you are banned");
            //}

            //else if (age < 18)
            //{
            //    Console.WriteLine("you are below 18");
            //}

            //else if (age < 80)
            //{
            //    Console.WriteLine("you can drive");
            //}

            //else
            //{
            //    Console.WriteLine("you can not drive");
            //}


            // while or do while loop :-
            //int i = 1;
            // while (i <= 5)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }


            // For loop:-
            //for (int i = 0; i < 5; i++) 
            //{
            //    Console.WriteLine( i + 1);

            //}


            //for (int i = 5; i >= 0 ; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            Greet("chirag");
            Console.WriteLine(average(2,3,5));
            Console.ReadLine();
            }
        }
    }
