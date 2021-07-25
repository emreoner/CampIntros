using HWGameAutomation.Abstract;
using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Concrete
{
    public class SaleServiceManager : ISaleService
    {
    
        public void Sell(Game game, Person member,Offer offer=null)
        {
            if (offer != null)
            {
                var sellPrice = game.Price - ((game.Price * offer.Rate) / 100);
                Console.WriteLine($"Sold game name : {game.Name} and price {sellPrice}");
            }
            else
                Console.WriteLine($"Sold game name : {game.Name} and price {game.Price}");

        }
    }
}
