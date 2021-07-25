using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Abstract
{
    public interface IOfferService
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
