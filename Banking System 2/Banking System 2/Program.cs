using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banking_System_2.Program;

namespace Banking_System_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.WriteLine("Welcome To Our Bank :");

            Console.WriteLine("1.Creat your account.");
            Console.WriteLine("2.Banking System.");

            string command = Console.ReadLine();

            if (command == "1")
            {
                showcreatecustomer();
            }
            else if (command == "2")
            {
                ShowBankingSystem();
            }

        }
        public static void showcreatecustomer()
        {
           Console.Clear();
           Console.WriteLine("Enter your name :");
           string name = Console.ReadLine();

            Console.WriteLine("Enter your id:");
            string id = Console.ReadLine();

            Customer customer = new Customer();
            customer.Name = name;
            customer.Id = int.Parse(id);

            Console.Clear();
            MainMenu();
        }

        public static void ShowBankingSystem() 
        {
            Console.Clear();
            Console.WriteLine(" BANKING SYSTEM :-");

            //Console.WriteLine("Enter your User Name :-");
            //string name = Console.ReadLine();
            

            Console.WriteLine("1: Deposit");
            Console.WriteLine("2: Transfer");
            Console.WriteLine("3: Check balance");
            Console.WriteLine("4: View History");
            Console.WriteLine("5: Check Balance");
            Console.WriteLine("7: Check Book Allotment");
            Console.WriteLine("8: Main Menu");

            string command2 = Console.ReadLine();

            if (command2 == "1") 
            {
                Console.Clear();
                Console.WriteLine("Enter The Id You Want To Transfer The Amount :");
                string id = Console.ReadLine();
                Console.WriteLine("Enter The Amount : ");
                string amount = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"Rs.{amount},is succesfully transfer to the id {id}.");
                
                Console.WriteLine("Enter * for the Main Menu And # For The Previous Menu.");
                string Command3 = Console.ReadLine();

                if (Command3 == "*") 
                {
                    Console.Clear();
                    MainMenu();
                }
                else if(Command3 == "#") 
                {
                    Console.Clear();
                    ShowBankingSystem();
                }
            }

            else if(command2 == "3")
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Id :");
                string id = Console.ReadLine();

                foreach (Customer myCustomer in Bank.AllCustomers)
                {
                    Console.WriteLine("Your Amount is :-" + myCustomer.Money);
                    Console.WriteLine("ID: " + myCustomer.Id + " Name: " + myCustomer.Name + " Money: " + myCustomer.Money);
                }
                    string amount = Console.ReadLine();



                

                int theCustomerId = int.Parse(id);
                Customer myFoundCustomer = null;

                foreach (Customer c in Bank.AllCustomers)
                {
                    if (c.Id == theCustomerId)
                    {
                        myFoundCustomer = c;
                        break;
                    }
                }

                if (myFoundCustomer != null)
                {
                    myFoundCustomer.Money += float.Parse(amount);
                }

                ShowBankingSystem();
            }

        }       
    }
}
