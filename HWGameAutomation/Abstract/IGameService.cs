using HWGameAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWGameAutomation.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
