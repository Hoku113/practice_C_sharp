using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class BreakContinue
    {
        public void BreakExample()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Breaked!!");
                    break;
                }
                Console.WriteLine(i);
            }
        }

        public void ContinueExample()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Continued!!");
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public void BreakWhile()
        {
            int i = 0;

            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    Console.WriteLine("Breaked!!");
                    break;
                }
            }
        }

        public void ContinueWhile()
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    Console.WriteLine("Continued!!");
                    continue;
                }
            }
        }
    }
}
