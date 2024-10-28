using DtoTest.DTO;
using DtoTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DtoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> listEmployees = new List<Employee>()
        {
            new Employee(){ Id = 1, Name = "Anurag", Age = 28, Salary=1000, Gender = "Male", Email = "Anurag@Example.com", SocialSecurityNumber="1234@Anurag" },
            new Employee(){ Id = 2, Name = "Pranaya", Age = 30, Salary=2000, Gender = "Male", Email = "Pranaya@Example.com", SocialSecurityNumber="4567@Pranaya" },
        };
        [HttpGet]
        public ActionResult<List<EmployeeDTO>> GetEmployees()
        {
            //We cannot expose the Sensitive Information
            //We are going to return the Employees to the Client using EmployeeDTO
            //So, manually creating instance and mapping the employees from Employee to EmployeeDTO
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            foreach (var employee in listEmployees)
            {
                EmployeeDTO emp = new EmployeeDTO()
                {
                    //Setting the Id, Name, Age, Gender, and Email
                    Id = employee.Id,
                    Name = employee.Name,
                    Age = employee.Age,
                    Gender = employee.Gender,
                    Email = employee.Email,
                };
                employees.Add(emp);
            }
            return Ok(employees);
        }
        [HttpPost]
        public ActionResult<EmployeeDTO> AddEmployee(EmployeeDTO employee)
        {
            if (employee != null && employee.Id == 0)
            {
                //Create an Instance of Employee Object and Populate the Properties manually
                Employee emp = new Employee()
                {
                    Id = listEmployees.Count + 1,
                    Name = employee.Name,
                    Age = employee.Age,
                    Gender = employee.Gender,
                    Email = employee.Email,
                    Salary = 3000,
                    SocialSecurityNumber = $"2356@{employee.Name}"
                };

                //Adding Employee Object into the Database
                listEmployees.Add(emp);
                //Setting the Employee ID in EmployeeDTO
                employee.Id = emp.Id;
                //Returning the EmployeeDTO
                return Ok(employee);
            }
            //If the Incoming Data in not Valid Return Bad Request
            return BadRequest();
        }
    }
}
