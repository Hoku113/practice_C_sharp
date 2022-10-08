using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class LoopThroughArrays
    {
        public void Example()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }

        public void Example2()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
