using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class UserInput
    {
        public void Example1()
        {
            Console.WriteLine("Enter username");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);
        }

        public void Example2()
        {
            Console.WriteLine("Enter your age:");

            // input int datatype
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

        }
    }
}
