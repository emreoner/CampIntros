using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Abstract
{
    public interface IOfferService
    {
        void Add(Offer offer);
        void Update(Offer offer);
        void Delete(Offer offer);
       
    }
}
