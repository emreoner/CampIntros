using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Abstract
{
    public interface IMembershipService
    {
        void Save(Person member);
        void Update(Person member);
        void Delete(Person member);
    }
}
