using System.Net.Sockets;

namespace ClassLibrary
{
    public class CareCenter
    {
        private int careCenterID;
        private string name;
        private Address address;
        private List<Resident> residents;

        public CareCenter(int careCenterID, string name, Address address, List<Resident> residents)
        {
            CareCenterID = careCenterID;
            Name = name;
            Address = address;
            Residents = residents;
        }

        public int CareCenterID { get => careCenterID; set => careCenterID = value; }
        public string Name { get => name; set => name = value; }
        public Address Address { get => address; set => address = value; }
        public List<Resident> Residents { get => residents; set => residents = value; }
    }
}
