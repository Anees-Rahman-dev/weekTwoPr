using WeekTwo_TaskOne.Model;

namespace WeekTwo_TaskOne.Service
{
    public interface IPlayerService
    {
        List<Player > GetAllPlayers();

        Player? GetById(int id);

        Player AddPlayer(Player player);

        bool DeletePlayer(int id);

        bool UpdatePlayer(int id, Player player);
    }
}