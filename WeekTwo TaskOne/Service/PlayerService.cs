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

        public List<Player> GetAllPlayers()
        {
            return players;
        }

        public Player? GetById(int id)
        {
            var FoundId = players.Find(F => F.Id == id);

            return FoundId;
        }

        public Player AddPlayer(Player player)
        {
            players.Add(player);
            return player;
        }

        public bool DeletePlayer(int id)
        {
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

        public bool UpdatePlayer(int id, Player player)
        {
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