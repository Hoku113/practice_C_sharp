using System;
using System.Collections.Generic;
using System.Text;

namespace SecondStep
{
    class OverLoading
    {
        public int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        public double PlusmethodDouble(double x, double y)
        {
            return x + y;
        }

        // Overloading
        public int PlusMethod(int x, int y)
        {
            return x + y;
        }

        public double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
