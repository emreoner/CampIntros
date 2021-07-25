using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Loan Calculated");
        }
    }
}
