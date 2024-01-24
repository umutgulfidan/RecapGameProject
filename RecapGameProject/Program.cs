using RecapGameProject.Concrete;
using RecapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = "1",
                Balance = 2500,
                DateOfBirth = DateTime.Now,
                FirstName = "Test",
                LastName = "Test",
            };

            UserManager userManager = new UserManager(new MernisUserCheckService());
            userManager.Add(user);
            Console.WriteLine("*********************************");

            SaleService saleService = new SaleService();
            saleService.Sell(user, new List<Game> {
                new Game { Price = 1000, Name = "God of War" },
                new Game { Price = 500 , Name = "RDR 2"}
            });
            Console.ReadKey();


        }
    }
}
