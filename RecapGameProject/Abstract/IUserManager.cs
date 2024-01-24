using RecapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapGameProject.Abstract
{
    public interface IUserManager
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
    }
}
