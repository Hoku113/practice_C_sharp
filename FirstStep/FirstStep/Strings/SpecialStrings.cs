using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class SpecialStrings
    {
        public void WrittenQuotes()
        {
            // write double quote
            string txt = "We are the so-called \" Vikings \" from the north.";
            Console.WriteLine(txt);

            // write single quote
            string txt1 = "It\'s alright";
            Console.WriteLine(txt1);

            // write single backslash
            string txt2 = "The character \\ is called backslash.";
            Console.WriteLine(txt2);
        }
    }
}
