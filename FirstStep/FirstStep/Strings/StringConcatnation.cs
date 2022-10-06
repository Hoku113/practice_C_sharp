using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class StringConcatnation
    {
        public void UsingPlusOperator()
        {
            // concatenation using '+' operator
            string FirstName = "Hello ";
            string LastName = "World";
            string name = FirstName + LastName;
            Console.WriteLine(name);

        }

        public void UsingConcat()
        {
            // concatenation using 'Concat' Method
            string FirstName = "Hello ";
            string LastName = "World";
            string name = string.Concat(FirstName, LastName);
            Console.WriteLine(name);

        }

        public void NumbersAndStrings()
        {
            int x = 10;
            int y = 20;
            int z = x + y; // z == 30

            string x1 = "10";
            string y1 = "20";
            string z1 = x1 + y1; // z1 == "1020"
        }
        
    }
}
