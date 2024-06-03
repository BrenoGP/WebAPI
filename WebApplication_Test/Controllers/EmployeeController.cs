using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using WebApplication_Test.Model;
using WebApplication_Test.ViewModel;

namespace WebApplication_Test.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpPost]
        public IActionResult Add(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Name, employeeView.Age, null);

            _employeeRepository.Add(employee);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get() 
        { 
            var employees = _employeeRepository.Get();
            
            return Ok(employees);
        }
    }
}
