using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGamerCheckService
    {
        public bool CheckIfItsReal(Gamer gamer);
    }
}
