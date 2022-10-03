using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class MultiVariables
    {
        public void Example()
        {
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);
        }

        public void Example2()
        {
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
        }
    }
}
