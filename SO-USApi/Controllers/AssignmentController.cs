using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using So_Us.DataAccess;
using SosuPower.DataAccess;
using SoUs.Entities;

namespace SO_USApi.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
        public class AssignmentController(IAssignmentRepository repository) : Controller
        {
            private readonly IRepository<SoUs.Entities.Assignment> repository;
            [HttpGet]
            public IEnumerable<Assignment> GetAll()
            {
                return repository.GetAll();
            }

            [HttpGet(nameof(GetBy))]
            public ActionResult<Assignment> GetBy(int id)
            {
                return repository.GetBy(id);
            }

            //[HttpGet(nameof(GetAssignmentsByDate))]
            //public IEnumerable<Assignment> GetAssignmentsByDate(DateTime date = default)
            //{
            //    if (date == default)
            //        date = DateTime.Now;
            //    return repository.GetAssignmentsOn(date);
            //}

            //[HttpGet(nameof(GetAssignmentsForEmployee))]
            //public IEnumerable<Assignment> GetAssignmentsForEmployee([FromQuery] Employee employee)
            //{
            //    return repository.GetAssignmentsFor(employee);
            //}

            [HttpPost]
            public void AddNew(Assignment task)
            {
                repository.Add(task);
            }

            [HttpPut]
            public void Update(Assignment assignment)
            {
                repository.Update(assignment);
            }

            [HttpDelete("DeleteById")]
            public void Delete(int id)
            {
                repository.Delete(id);
            }

            [HttpDelete]
            public void Delete(Assignment assignment)
            {
                repository.Delete(assignment); ;
            }
        }



       


    
}
