using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Abstract
{
    public interface ISaleService
    {
        void Sell(Game game, User member, Offer offer);
    }
}
