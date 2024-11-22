using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApp
{
    public class Car
    {

        // Member Variable
        // private hides the variable from other classes
        private string _model = "";
        private string _brand = "";

        // ! Constructor
        // Constructor is called every time when class instance is created
        public Car(string brand, string model)
        {
            _brand = brand;
            _model = model;
            Console.WriteLine($"The {_brand} car of model {_model} has been created.");
        }

    }
}