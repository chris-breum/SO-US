using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Task
    {
        private int taskID;
        private string name;
        private DateTime timeStart;
        private DateTime timeEnd;
        private string notes;
        private Resident resident;
        private List<Employee> employee;
        private List<Medicine> medicines;

        public Task(int taskID, string name, DateTime timeStart, DateTime timeEnd, string notes, Resident resident, List<Employee> employee, List<Medicine> medicines)
        {
            TaskID = taskID;
            Name = name;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Notes = notes;
            Resident = resident;
            Employee = employee;
            Medicines = medicines;
        }

        public int TaskID { get => taskID; set => taskID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime TimeStart { get => timeStart; set => timeStart = value; }
        public DateTime TimeEnd { get => timeEnd; set => timeEnd = value; }
        public string Notes { get => notes; set => notes = value; }
        public Resident Resident { get => resident; set => resident = value; }
        public List<Employee> Employee { get => employee; set => employee = value; }
        public List<Medicine> Medicines { get => medicines; set => medicines = value; }
    }
}
