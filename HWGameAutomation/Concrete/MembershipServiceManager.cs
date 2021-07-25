using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Concrete
{
    public class MembershipServiceManager : IMembershipService
    {
        ICheckRealPersonService checkRealPersonService;

        public MembershipServiceManager(ICheckRealPersonService checkRealPersonService)
        {
            this.checkRealPersonService = checkRealPersonService;
        }

        public void Delete(Person member)
        {
            Console.WriteLine("Deleted from DB " + member.FirstName);
        }

        public void Save(Person member)
        {

            if (checkRealPersonService.CheckIfRealPerson(member))
            {
                Console.WriteLine("Saved to DB " + member.FirstName);
            }
            else
                throw new Exception("Not a Valid Member Info");
        }

        public void Update(Person member)
        {
            if (checkRealPersonService.CheckIfRealPerson(member))
            {
                Console.WriteLine("Updated Member : " + member.FirstName);
            }
            else
                throw new Exception("Not a Valid Member Info");
            
        }
    }
}
