using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class Array_test
    {
        public void ArrayExample()
        {
            // Access Element
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            // Change Array Element
            cars[0] = "Opel";
            Console.WriteLine($"new array element: {cars[0]}");

            // Show array length
            Console.WriteLine(cars.Length);


        }

        public void OtherWayCreateArray()
        {
            // example1
            string[] cars = new string[4];

            // example2
            string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // example3
            string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // example4
            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
        }
    }
}
