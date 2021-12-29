using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager:BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfItsReal(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid Gamer");
            }
        }
    }
}
