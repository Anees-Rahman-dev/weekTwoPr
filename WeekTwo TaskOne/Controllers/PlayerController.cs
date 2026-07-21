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
        [HttpGet("{id}")]
        public IActionResult GetPlayer(int id)
        {
            var player = _playerService.GetById(id);

            if (player != null)
            {
                return Ok(player);
            }
            else
            {
                return NotFound("Couldnt Find the player");
            }
        }
        [HttpPut("{id}")]
        public IActionResult updatePlayer(int id, Player playerinfo)
        {
            var player = _playerService.UpdatePlayer(id, playerinfo);

            if (player == null)
            {
                return NotFound("Cannot update it");
            }
            else
            {
                return Ok(player);
            }
        }




    }
}