using RecapGameProject.Abstract;
using RecapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapGameProject.Concrete
{
    public class MernisUserCheckService : IUserCheckService
    {
        public bool CheckIfRealUser(User user)
        {
            // Burada parametre olarak gelen kullanıcının doğum yılı , ismi , soyismi ile Mernis üzerinden doğrulama yapılıp
            // sonucun döndürüldüğü varsayılmıştır
            Console.WriteLine("Mernis tarafından doğrulandı");
            return true;
        }
    }
}
