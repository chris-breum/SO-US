using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Address
    {
        private int addressId;
        private string street;
        private string city;
        private string state;
        private int zipCode;

        public Address(int addressId, string street, string city, string state, int zipCode)
        {
            AddressId = addressId;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public int AddressId { get => addressId; set => addressId = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int ZipCode { get => zipCode; set => zipCode = value; }
    }
}
