using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
     public abstract class BaseGamerManager
    {
        public virtual void Save(Gamer gamer) 
        {
            Console.WriteLine("Saved to db :"+gamer.FirstName);
        }

        public virtual void update(Gamer gamer)
        {
            Console.WriteLine("Updated to db:"+gamer.FirstName);
        }

        public virtual void delete(Gamer gamer) 
        {
            Console.WriteLine("Deleted to db:"+gamer.FirstName);
        }

    }
}
