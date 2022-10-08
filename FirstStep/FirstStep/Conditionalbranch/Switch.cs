using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class Switch
    {
        public void SwitchExample()
        {
            int day = 4;

            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;

            }
        }

        public void SwitchExample2()
        {
            // use default keyword

            int day = 4;

            switch (day)
            {
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Looking forward to the Weekend."); break;
            }
        }
    }
}
