using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Concrete
{
    public class CheckRealPersonServiceManager : ICheckRealPersonService
    {
        public bool CheckIfRealPerson(User member)
        {
            return true;
        }
    }
}
