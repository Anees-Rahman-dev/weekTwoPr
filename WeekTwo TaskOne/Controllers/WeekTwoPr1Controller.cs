using Microsoft.AspNetCore.Mvc;
using WeekTwo_TaskOne.Model;

namespace WeekTwo_TaskOne.Controllers
{
    public class WeekTwoPr1Controller : ControllerBase
    {

        private static List<WeekTwoPr1> pr1 = new List<WeekTwoPr1>
        {
            new WeekTwoPr1 {Id = 1 , Name = "pravach" , Age = 23},
            new WeekTwoPr1 {Id = 2 , Name = "shifin" , Age = 24},
            new WeekTwoPr1 {Id = 3 , Name = "rayis" , Age = 25},
            new WeekTwoPr1 {Id = 4 , Name = "snehul" , Age = 23},
        };

        [HttpGet("{id}")]
        public IActionResult getById (int id)
        {
            var foundId = pr1.FirstOrDefault( X => X.Id == id);

            if (foundId != null)
            {
                return Ok(foundId);
            }
            else
            {
                return BadRequest();
            }

           
        }
    }
}
