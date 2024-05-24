using Microsoft.AspNetCore.Mvc;
using SosuPower.DataAccess;
using SoUs.Entities;

namespace SO_USApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController(IEmployeeRepository repository) : Controller
    {
        private readonly IRepository<SoUs.Entities.Employee> repository;

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }
        [HttpGet("id")]
        public ActionResult<Employee> GetBy(int id)
        {
            return repository.GetBy(id);
        }
        [HttpPost]
        public void AddNew(Employee employee)
        {
            repository.Add(employee);
        }
        [HttpPut]
        public void Update(Employee employee)
        {
            repository.Update(employee);
        }
        [HttpDelete("DeleteById")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
        

    }
}
