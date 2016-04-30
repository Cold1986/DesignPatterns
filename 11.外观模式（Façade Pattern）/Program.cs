using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //外观
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Ann McKinsey");
            bool eligable = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligable ? "Approved" : "Rejected"));
            Console.ReadLine();
        }
    }
}
