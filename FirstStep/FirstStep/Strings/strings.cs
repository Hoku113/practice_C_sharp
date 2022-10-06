using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class strings
    {
        public void Strings_contains()
        {
            // normal
            string greeting = "Hello";
            string greeting2 = "Nice to meet you";

            // string length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt strings is : " + txt.Length);

            // Upper and lower
            Console.WriteLine(greeting.ToUpper());
            Console.WriteLine(greeting.ToLower());
        }
    }
}
