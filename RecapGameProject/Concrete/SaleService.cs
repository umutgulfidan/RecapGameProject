using RecapGameProject.Abstract;
using RecapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapGameProject.Concrete
{
    public class SaleService : ISaleService
    {
        public void Sell(User user, List<Game> games)
        {
            Console.WriteLine("Kullanıcı: "+user.FirstName + " " + user.LastName);
            double totalPrice = 0;
            Console.WriteLine(" ----------------------------------\n" +
                "Oyunlar:");

            foreach (Game game in games)
            {
                Console.WriteLine(game.Name + " : "+game.Price);
                totalPrice += game.Price;
            }
            if(user.Balance > totalPrice)
            {
                Console.WriteLine("Yukarıdaki oyunlar başarıyla satın alındı");
                user.Balance -= totalPrice;
                Console.WriteLine("Kalan Bakiyeniz :"+user.Balance);
            }
            else
            {
                throw new Exception("Kullanıcı Bakiyesi yetersiz");
            }
        }
    }
}
