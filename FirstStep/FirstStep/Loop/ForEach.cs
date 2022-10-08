using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class ForEach
    {
        public void ArrayLoop()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
