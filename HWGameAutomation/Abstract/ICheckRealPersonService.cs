using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Abstract
{
    public interface ICheckRealPersonService
    {
        bool CheckIfRealPerson(User member);
    }
}
