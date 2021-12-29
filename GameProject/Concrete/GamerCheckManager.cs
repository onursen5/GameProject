using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfItsReal(Gamer gamer)
        {
            return true;
        }
    }
}
