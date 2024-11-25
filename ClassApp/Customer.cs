using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // * Default Constructor
        public Customer()
        {
            Name = "N/A";
            Address = "N/A";
            ContactNumber = "N/A";
        }

        // * Custom constructor with multiple parameters
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // * Custom constructor with single parameters
        public Customer(string name)
        {
            Name = name;
        }
    }
}