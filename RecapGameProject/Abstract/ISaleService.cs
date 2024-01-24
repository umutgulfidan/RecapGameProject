using RecapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapGameProject.Abstract
{
    public interface ISaleService
    {
        void Sell(User user , List<Game> games);
    }
}
