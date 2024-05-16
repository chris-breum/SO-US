using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Medicine
    {
        private int medicineID;
        private string name;
        private string dosage;
        private int amount;
        private bool administered;

        public Medicine(int medicineID, string name, string dosage, int amount, bool administered)
        {
            MedicineID = medicineID;
            Name = name;
            Dosage = dosage;
            Amount = amount;
            Administered = administered;
        }

        public int MedicineID { get => medicineID; set => medicineID = value; }
        public string Name { get => name; set => name = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public int Amount { get => amount; set => amount = value; }
        public bool Administered { get => administered; set => administered = value; }
    }
}
