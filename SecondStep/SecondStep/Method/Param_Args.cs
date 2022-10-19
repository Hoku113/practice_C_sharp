using System;
using System.Collections.Generic;
using System.Text;

namespace SecondStep
{
    class Param_Args
    {
        public void Parameter(string fname)
        {
            Console.WriteLine($"{fname} Refsnes");
        }

        public void MultiParameters(string fname, int age)
        {
            Console.WriteLine($"{fname} is {age}");
        }
    }
}
