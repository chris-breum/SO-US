using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        private int employeeID;
        private string name;
        private List<Task> tasks;
        private List<Role> role;
        private CareCenter careCenter;

        public Employee(int employeeID, string name, List<Task> tasks, List<Role> role, CareCenter careCenter)
        {
            EmployeeID = employeeID;
            Name = name;
            Tasks = tasks;
            Role = role;
            CareCenter = careCenter;
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string Name { get => name; set => name = value; }
        public List<Task> Tasks { get => tasks; set => tasks = value; }
        public List<Role> Role { get => role; set => role = value; }
        public CareCenter CareCenter { get => careCenter; set => careCenter = value; }
    }
}
