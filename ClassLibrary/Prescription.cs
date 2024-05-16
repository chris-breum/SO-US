using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Prescription
    {
        private int prescriptionID;
        private string name;
        private string dosage;
        private int amount;

        public Prescription(int prescriptionID, string name, string dosage, int amount)
        {
            PrescriptionID = prescriptionID;
            Name = name;
            Dosage = dosage;
            Amount = amount;
        }

        public int PrescriptionID { get => prescriptionID; set => prescriptionID = value; }
        public string Name { get => name; set => name = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
