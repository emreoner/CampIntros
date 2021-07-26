using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Abstract
{
    public interface IMembershipService
    {
        void Save(User member);
        void Update(User member);
        void Delete(User member);
    }
}
