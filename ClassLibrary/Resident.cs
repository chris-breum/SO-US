using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Resident
    {
        private int residentID;
        private string name;
        private string roomNumber;
        private List<Prescription> prescriptions;
        private string notes;

        public Resident(int residentID, string name, string roomNumber, List<Prescription> prescriptions, string notes)
        {
            ResidentID = residentID;
            Name = name;
            RoomNumber = roomNumber;
            Prescriptions = prescriptions;
            Notes = notes;
        }

        public int ResidentID { get => residentID; set => residentID = value; }
        public string Name { get => name; set => name = value; }
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public List<Prescription> Prescriptions { get => prescriptions; set => prescriptions = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
