using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class While
    {
        public void WhileExample()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileExmaple()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            
        }
    }
}
