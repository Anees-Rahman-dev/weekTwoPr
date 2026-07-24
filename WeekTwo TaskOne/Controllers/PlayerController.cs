using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
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
        public async Task<IActionResult> GetPlayers()
        {
            var player = await _playerService.GetAllPlayers();

            return Ok(player);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayer(int id)
        {
            try
            {
                var player = await _playerService.GetById(id);

                if (player == null)

                    return NotFound("player not found");

                return Ok(player);
            }catch (Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
            
           
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updatePlayer(int id, Player playerinfo)
        {
            var player = await _playerService.UpdatePlayer(id, playerinfo);

            if (!player )
            {
                return NotFound("Cannot update it");
            }
            else
            {
                return Ok("player added successfully");
            }
        }


        [HttpPost]

        public async Task<IActionResult> addPlayer(Player playerToAdd)
        {
          var newPlayer =  await _playerService.AddPlayer(playerToAdd);

            return CreatedAtAction(nameof(GetPlayer),
                new {id = newPlayer.Id},
                newPlayer);

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> deletePlayer(int id)
        {
            var DeletePlayer = await _playerService.DeletePlayer(id);
            if (!DeletePlayer)
            {
                return NotFound("player not found");
                
            }
            else
            {
                return NoContent();
            }
        }

    }
}