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
            var getById = emp.Where(W => W.Id == id);

            if (getById != null)
            {
                return Ok(getById);
            }
            else
            {
                return NotFound("cannot find employee with this id");
            }
        }

        [HttpPut("{id}{Id, Name, Age}")]
        public IActionResult UpdateEmployees(int id, Employees data)
        {
            var getById = emp.Find(F => F.Id == id);

            if (getById != null)
            {
                getById.Id = data.Id;
                getById.Name = data.Name;
                getById.Age = data.Age;
                return Ok("successFully Updated");
            }
            else
            {
                return NotFound("there is some issue");
            }
        }
       
    }
}
