using RecapGameProject.Abstract;
using RecapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapGameProject.Concrete
{
    public class UserManager : IUserManager

    {
        IUserCheckService _userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public void Add(User user)
        {
            if (_userCheckService.CheckIfRealUser(user))
            {
                Console.WriteLine("Kullanıcı Eklendi:" + user.FirstName + " " + user.LastName);
            }
            else
            {
                throw new Exception("Kullanıcı Doğrulanamadı");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı Silindi:" + user.FirstName + " " + user.LastName);
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı Hüncellendi:" + user.FirstName + " " + user.LastName);
        }
    }
}
