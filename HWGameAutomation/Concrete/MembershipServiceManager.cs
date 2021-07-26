using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Concrete
{
    public class MembershipServiceManager : IMembershipService
    {
        ICheckRealPersonService _checkRealPersonService;

        public MembershipServiceManager(ICheckRealPersonService checkRealPersonService)
        {
            this._checkRealPersonService = checkRealPersonService;
        }

        public void Delete(User member)
        {
            Console.WriteLine("Deleted from DB " + member.FirstName);
        }

        public void Save(User member)
        {

            if (_checkRealPersonService.CheckIfRealPerson(member))
            {
                Console.WriteLine("Saved to DB " + member.FirstName);
            }
            else
                throw new Exception("Not a Valid User Info");
        }

        public void Update(User member)
        {
            if (_checkRealPersonService.CheckIfRealPerson(member))
            {
                Console.WriteLine("Updated User : " + member.FirstName);
            }
            else
                throw new Exception("Not a Valid User Info");
            
        }
    }
}
