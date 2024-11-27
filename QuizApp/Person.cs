using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Person
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        private int _age;
        public int Age
        {
            get => _age; set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}