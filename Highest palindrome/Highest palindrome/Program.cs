using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Highest_palindrome.Program;

namespace Highest_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Bank");
            
            Console.WriteLine("1: Create customer");
            Console.WriteLine("2: Banking Function");
            

            string command = Console.ReadLine();

            if (command == "1")
            {
                ShowCreateCustomer();
            }
            else if (command == "2")
            {
                BankingFunction();
            }
        }

        public static void BankingFunction()
        {
            Console.Clear();
            Console.WriteLine(" All Customers ");

            foreach (Customer myCustomer in Bank.AllCustomers)
            {
                Console.WriteLine("ID: " + myCustomer.Id + " Name: " + myCustomer.Name + " Money: " + myCustomer.Money);
            }

            Console.WriteLine("1: Deposit");
            Console.WriteLine("2: Transfer");
            Console.WriteLine("3: Check balance");
            Console.WriteLine("4: Cheque book allotment.");
            Console.WriteLine("8: Main Menu");

            string command = Console.ReadLine();

            if (command == "1")
            {                
                Console.Write("Enter the id of the customer: ");
                string customerId = Console.ReadLine();
                Console.Write("Enter the amount to deposit: ");
                string amount = Console.ReadLine();

                int theCustomerId = int.Parse(customerId);
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

                BankingFunction();
            }
            else if (command == "2")
            {
                TransferMoney();
            }
            else if (command == "3")
            {
                Checkbalance();
            }
            else if (command == "4")
            {
                Chequebook();
            }

            else if (command == "8")
            {
                MainMenu();
            }
        }

        public static void Chequebook()
        {
            Console.Clear();
            Console.WriteLine("Enter your id:-");
            string id = Console.ReadLine();
            Console.WriteLine("Your Cheque Book Is Under Process.");
            Console.ReadLine();
            Console.WriteLine("Press 1* for main menu and # for previous menu.");
            string com = Console.ReadLine();
             if (com == "*")
            {
                MainMenu();
            }
            else if (com =="#")
            {
                BankingFunction();
            }
           
        }

        public static void Checkbalance()
        {
            Console.Clear();
            Console.Write("Enter the id of the customer: ");
            string customerId = Console.ReadLine();

            Console.WriteLine("your balance is :-" );
            string balance = Console.ReadLine();

            int theCustomerId = int.Parse(customerId);
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
                myFoundCustomer.Money += float.Parse(balance);
            }

            Console.ReadLine();

            BankingFunction();
        }

        public static void ShowCreateCustomer()
        {
            Console.Clear();
            Console.WriteLine("--- Create new Customer ---");
            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the id: ");
            string id = Console.ReadLine();
            Customer customer = new Customer();
            customer.Name = name;
            customer.Id = int.Parse(id);
            
            Bank.AllCustomers.Add(customer);
            
            MainMenu();
        }

        public static void TransferMoney()
        {
            Console.Clear();
            Console.WriteLine("--- Transfer Money ---");
            Console.Write("Please enter your account's ID: ");
            string id = Console.ReadLine();
            Console.Write("Please enter the Name of the person you would like to tranfer funds to: ");
            string name = Console.ReadLine();
            Console.Write("Enter the amount of funds you would like to transfer: ");
            string amount = Console.ReadLine();

            BankingFunction();
        }

        public class Customer
        {
            public Customer()
            {
                Money = 00;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public float Money { get; set; }
        }

        public class Bank
        {
            private static List<Customer> customers = new List<Customer>();

            public Bank()
            {
                customers = new List<Customer>();
            }

            public static List<Customer> AllCustomers
            {
                get { return customers; }
            }
        }
    }
}
