using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class ShowDataTypes
    {
        public void Numbers()
        {
            // int
            int myNum = 10000;
            Console.WriteLine("int: " + myNum);

            // long
            long long_num = 15000000L;
            Console.WriteLine("long: " + long_num);

            // float
            float float_num = 5.75F;
            Console.WriteLine("float:" + float_num);

            // double
            double double_num = 19.99D;
            Console.WriteLine("double: " + double_num);
            
        }

        public void ScientificNumbers()
        {
            // e == indicate the power of 10;
            float f1 = 35e3F;
            double d1 = 12e4D;

            Console.WriteLine("Scientific float:" + f1);
            Console.WriteLine("Scientific double:" + d1);
        }

        public void Booleans()
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine("bool:" + isCSharpFun);
            Console.WriteLine("bool:" + isFishTasty);
        }

        public void Characters()
        {
            // You must use ''.
            char myGrade = 'B';
            Console.WriteLine("char:" + myGrade);
        }

        public void Strings()
        {
            // You must use "".
            string greeting = "Hello World";
            Console.WriteLine("string:" + greeting);
        }
    }
}
