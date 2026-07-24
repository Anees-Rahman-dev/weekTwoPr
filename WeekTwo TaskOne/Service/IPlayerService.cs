using WeekTwo_TaskOne.Model;

namespace WeekTwo_TaskOne.Service
{
    public interface IPlayerService
    {
        Task<List<Player>> GetAllPlayers();

        Task<Player?> GetById(int id);

        Task<Player> AddPlayer(Player player);

        Task<bool> UpdatePlayer(int id, Player player);

        Task<bool> DeletePlayer(int id);
    }
}