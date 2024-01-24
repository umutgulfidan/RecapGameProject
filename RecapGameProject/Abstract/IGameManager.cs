using RecapGameProject.Entities;

namespace RecapGameProject.Abstract
{
    public interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
