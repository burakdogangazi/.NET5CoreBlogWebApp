using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new ApiContext();

            var values = c.Employees.ToList();

            return Ok(values);
        }

        [HttpPost]

        public IActionResult AddEmployee(Employee employee)
        {

            using var c = new ApiContext();

            c.Add(employee);
            c.SaveChanges();
            return Ok();    
        }

        [HttpGet("{id}")]

        public IActionResult EmployeeGet(int id)
        {
            using var c = new ApiContext();
            var employee = c.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();

            }

            else
            {
                return Ok(employee);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {

            using var c = new ApiContext();

            var employee = c.Employees.Find(id);

            if(employee == null)
            {
                return NotFound();
            }

            else
            {
                c.Employees.Remove(employee);
                c.SaveChanges();
                return Ok();
            }

        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {

            using var c = new ApiContext();

            var dbEmployee = c.Employees.Find(employee);

           // var emp = c.Employees.Find<Employee>(employee.ID)
            if(dbEmployee == null)
            {
                return NotFound();
            }

            else
            {
                dbEmployee.Name = employee.Name;
                c.Employees.Update(employee);
                return Ok();
            }
        }


    }
}
