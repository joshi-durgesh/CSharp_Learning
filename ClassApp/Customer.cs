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

        // * Creating Id
        private static int nextId = 0;
        // * Readonly Field
        private readonly int _id;
        // * Readonly Property
        public int Id { get { return _id; } }

        // * password
        private string _password;

        //* Writeonly property
        public string Password { set { _password = value; } }

        // * Default Constructor
        public Customer()
        {
            _id = nextId++;
            Name = "N/A";
            Address = "N/A";
            ContactNumber = "N/A";
            Password = "N/a";
        }

        // * Custom constructor with multiple parameters
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextId++;

            Name = name;
            Address = address;
            ContactNumber = contactNumber;
            Password = "";
        }

        // * Custom constructor with single parameters
        // public Customer(string name)
        // {
        //     Name = name;
        // }

        // Method to update varialbe 
        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}