using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGamerService
    {
       public void Add(Gamer gamer);
       public void Save(Gamer gamer);
       public void Delete(Gamer gamer);
    }
}
