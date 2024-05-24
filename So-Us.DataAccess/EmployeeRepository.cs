using SosuPower.DataAccess;
using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Us.DataAccess
{
    internal class EmployeeRepository(DataContext dataContext) :
        Repository<Employee>(dataContext),IEmployeeRepository
    {



    }
}
