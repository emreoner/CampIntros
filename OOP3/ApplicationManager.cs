using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method Injection
        public void ApplyForLoan(ILoanManager loanManager,ILoggerService loggerService)
        {
            //Basvuran bilgilerini degerlendirme
            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();
            //loan manager gonderilen herhangi bir loan manager'in referansini tutabilir
            loanManager.Calculate();
            loggerService.Log();
           
        }

        public void GiveLoanInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }

        }
    }
}
