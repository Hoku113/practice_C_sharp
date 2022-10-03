using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class Display_variables
    {
        public void Display() {
            string name = "Hello";
            Console.WriteLine(name + "World!!");
        }

        public void Example1()
        {
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
        }

        public void Example2()
        {
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);
        }

    }
}
