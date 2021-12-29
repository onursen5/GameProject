using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void sale(Gamer gamer)
        {
            Console.WriteLine("Sale is completed thank you" +  gamer.FirstName);
        }

        
    }
}
