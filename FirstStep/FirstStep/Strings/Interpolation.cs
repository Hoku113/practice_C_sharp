using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class Interpolation
    {
        public void StringInterpolation()
        {
            // String interpolation = format() and 'f'strings by python code
            string FirstName = "John";
            string LastName = "Doe";
            string name = $"My full name is: {FirstName} {LastName}";

            Console.WriteLine(name);
        }
    }
}
