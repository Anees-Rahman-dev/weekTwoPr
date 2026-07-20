using Microsoft.AspNetCore.Mvc;
using WeekTwo_TaskOne.Controllers;
using WeekTwo_TaskOne.Model;


namespace WeekTwo_TaskOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {

        private static List<Employees> emp = new List<Employees>
        {
            new Employees {Id = 1 , Name = "messi" , Age = 23},
            new Employees {Id = 2 , Name = "rocky" , Age = 24},
            new Employees {Id = 3 , Name = "garuda" , Age = 25},
            new Employees {Id = 4 , Name = "luffy" , Age = 23},
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(emp);
        }

        [HttpPost]
        public IActionResult PostEmployees(Employees employees)
        {
            if (employees != null)
            {
                emp.Add(employees);
                return Ok("added new Employees successFully");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var getbyid = emp.Where(W => W.Id == id);

            if (getbyid != null)
            {
                return Ok(getbyid);
            }
            else
            {
                return NotFound("cannot find employee with this id");
            }
        }
       
    }
}
