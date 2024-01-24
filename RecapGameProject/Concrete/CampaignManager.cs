using RecapGameProject.Abstract;
using RecapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapGameProject.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi:" + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi:" + campaign.Name);

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi:" + campaign.Name);

        }
    }
}
