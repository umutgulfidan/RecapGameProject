using RecapGameProject.Entities;

namespace RecapGameProject.Abstract
{
    public interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
