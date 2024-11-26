using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassApp
{
    public class CodingExercise
    {
        private readonly string _value = "";
        public string FieldValue
        {
            get { return _value; }
        }

        public CodingExercise(string value)
        {
            _value = value;
        }
    }
}