using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApp
{
    public class Car
    {

        //! Member Variable
        // private hides the variable from other classes
        private string _model = "";
        private string _brand = "";

        //! Properties
        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand; set => _brand = value; }

        // ! Constructor
        // Constructor is called every time when class instance is created
        public Car(string brand, string model)
        {
            Model = brand;
            Brand = model;
            Console.WriteLine($"The {Brand} car of model {Brand} has been created.");
        }

    }
}