using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    //贷款子系统
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("check loans for " + c.Name);
            return true;
        }
    }
}
