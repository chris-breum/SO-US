using So_Us.DataAccess;
using SoUs.Entities;

namespace SosuPower.DataAccess
{
    public class AssignmentRepository(DataContext dataContext) :
        Repository<Assignment>(dataContext), IAssignmentRepository
    {
        public IEnumerable<Assignment> GetAssignmentsFor(Employee employee)
        {
            return sosuPowerContext.Tasks.Where(a => a.Employees.Contains(employee));
        }

        public IEnumerable<Assignment> GetAssignmentsOn(DateTime date)
        {
            return dataContext.Tasks.Where(a => a.TimeStart == date.Date);
        }
    }
}