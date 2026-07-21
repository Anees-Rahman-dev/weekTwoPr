using Microsoft.AspNetCore.Mvc;
using WeekTwo_TaskOne.Model;
using WeekTwo_TaskOne.Service;

namespace WeekTwo_TaskOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService PlayerService)
        {
            _playerService = PlayerService;
        }

        [HttpGet]
        public List<Player> GetPlayers()
        {
            return _playerService.GetAllPlayers();
        }

       
    }
}