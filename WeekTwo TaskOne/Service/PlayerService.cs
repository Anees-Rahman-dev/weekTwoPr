using WeekTwo_TaskOne.Model;

namespace WeekTwo_TaskOne.Service
{
    public class PlayerService : IPlayerService
    {
        private static List<Player> players = new()
        {
            new Player { Id = 1, Name = "Totti", Age = 27, Club = "Roma", JerseyNumber = 10 },
            new Player { Id = 2, Name = "Pogba", Age = 25, Club = "Juventus", JerseyNumber = 44 },
            new Player { Id = 3, Name = "Kaka", Age = 24, Club = "AC Milan", JerseyNumber = 7 }
        };

        public async Task<List<Player>> GetAllPlayers()
        {
            await Task.Delay(500);
            return players;
        }

        public async Task<Player?> GetById(int id)
        {
            await Task.Delay(500);
            var FoundId = players.Find(F => F.Id == id);

            return FoundId;
        }

        public async Task<Player> AddPlayer(Player player)
        {
            await Task.Delay(500);
            players.Add(player);
            return player;
        }

        public async Task<bool> DeletePlayer(int id)
        {
            await Task.Delay(500);
            var FoundId = players.Find(F => F.Id == id);

            if (FoundId == null)
            {
                return false;

            }
            else
            {
                players.Remove(FoundId);
                return true;
            }
        }

        public async Task<bool> UpdatePlayer(int id, Player player)
        {
            await Task.Delay(500);
            var FoundId = players.Find(F => F.Id == id);

            if (FoundId == null)
            {
                return false;
            }
            else
            {
                FoundId.Name = player.Name;
                FoundId.JerseyNumber = player.JerseyNumber;
                FoundId.Club = player.Club;
                FoundId.Age = player.Age;
                return true;
            }
        }

    }
        
}