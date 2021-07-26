using HWGameAutomation.Adapters;
using HWGameAutomation.Concrete;
using HWGameAutomation.Entities;
using System;

namespace HWGameAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            User person = new Gamer()
            {
                Id = 1,
                FirstName = "EMRE",
                LastName = "LastNAme",
                DateOfBirth = new DateTime(1990, 7, 5),
                IdentityNumber = "12345678910"
            };

            Game game = new Game
            {
                Id = 1,
                Name = "MedalOfHonnor 4",
                Price = 400
            };

            Offer offer = new Offer
            {
                Id = 1,
                Name = "Summer Sale",
                Rate = 20
            };

            MembershipServiceManager membershipServiceManager = new MembershipServiceManager(new MernisServiceAdapter());
            membershipServiceManager.Save(person);

            SaleServiceManager saleServiceManager = new SaleServiceManager();
            saleServiceManager.Sell(game, person);
        }
    }
}
