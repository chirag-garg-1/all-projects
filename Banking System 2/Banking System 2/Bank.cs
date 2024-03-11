using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_2
{
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
