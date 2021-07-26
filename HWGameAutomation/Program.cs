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
                LastName = "ÖNER",
                DateOfBirth = new DateTime(1989, 6, 5),
                IdentityNumber = "51730724414"
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
