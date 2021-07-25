using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager consumerLoanManager = new ConsumerLoanManager();
           // consumerLoanManager.Calculate();

            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();

            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ApplyForLoan(vehicleLoanManager,new DatabaseLoggerService());

            List<ILoanManager> loans = new List<ILoanManager>() { consumerLoanManager, vehicleLoanManager };

            //applicationManager.GiveLoanInformation(loans);


            

        }
    }
}
