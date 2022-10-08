using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class Short_If_Else
    {
        public void ShortHand()
        {
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
