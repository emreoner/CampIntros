using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Concrete
{
    public class CheckRealPersonServiceManager : ICheckRealPersonService
    {
        public bool CheckIfRealPerson(Person member)
        {
            return true;
        }
    }
}
