using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class type_casting
    {
        /*
         Impilcit Casting
        char -> int -> long -> float -> doule
         */
        public void ImplicitCasting()
        {
            // Automatic casting: int to double
            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
        }

        /*
         Explicit Casting
        double -> float -> long -> int -> char
         */
        public void ExplicitCasting()
        {
            // This is Manual casting
            double myDouble = 9.78;
            int myInt = (int) myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
        }

        public void TypeConversionMethods()
        {
            // Conversion using built-in methods
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
