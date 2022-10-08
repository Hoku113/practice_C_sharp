using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class For
    {
        public void ForExample()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i}, ");
            }

            Console.Write("\n");

            // Another Example (increase by 2)
            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.Write($"{i}, ");
            }
        }

    }
}
