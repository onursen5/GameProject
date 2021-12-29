using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                DateOfBirth = new DateTime(2000, 09, 13),
                FirstName = "Süleyman",
                LastName = "Sarıtaş",
                NationalityId = 10885138262
            };
            SalesManager salesManager = new SalesManager();
            salesManager.sale(gamer);

        }
    }
}
