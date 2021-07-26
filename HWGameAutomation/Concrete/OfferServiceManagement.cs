using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Concrete
{
    public class OfferServiceManagement : IOfferService
    {
 
        public void Add(Offer offer)
        {
            Console.WriteLine("Offer Added");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Offer deleted");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Offer updated");
        }

        


    }
}
