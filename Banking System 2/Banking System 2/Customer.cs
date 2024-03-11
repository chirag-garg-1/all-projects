using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_2
{
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
}
