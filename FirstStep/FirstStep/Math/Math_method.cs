using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class Math_method
    {
        public void Math_Calculate()
        {
            // show max value
            Console.WriteLine( "max value:" + Math.Max(5, 10));

            // show min value
            Console.WriteLine("min value:" + Math.Min(5, 10));

            // show square value
            Console.WriteLine("square :" + Math.Sqrt(64));

            // show absolute value
            Console.WriteLine("absolute :" + Math.Abs(-4.7));

            // show round value
            Console.WriteLine("round : " + Math.Round(9.99));


        }
    }
}
