using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Concrete
{
    public class OfferServiceManagement : IOfferService
    {
        public void Add(Person person)
        {
            Console.WriteLine($"Offer added for gamer : {person.FirstName}");
        }

        public void Delete(Person person)
        {
            Console.WriteLine("Offer deleted");
        }

        public void Update(Person person)
        {
            Console.WriteLine("Offer updated");
        }
    }
}
