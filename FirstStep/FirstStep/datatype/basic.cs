using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstStep
{
    class basic
    {
        public void Datatype()
        {
            /* datatype */
            int a = 5;
            bool test = true;


            // Declaration only
            float temperature;
            string name;

            // Declaration withh initializers
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4 };
            var query = from item in source
                        where item <= limit
                        select item;


            Console.WriteLine(a);
            Console.WriteLine(test);
            Console.WriteLine(firstLetter);
            Console.WriteLine(limit);
            Console.WriteLine(source);
            Console.WriteLine(query);
        }
    }
}