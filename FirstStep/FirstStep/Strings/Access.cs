using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStep
{
    class Access
    {
        public void AccessStrings()
        {
            string myString = "Hello";
            Console.WriteLine(myString[0]);

            // using indexOf method
            Console.WriteLine(myString.IndexOf("e"));
        }

        public void ExtractsCharacters()
        {
            // Extracts the characters from a string which using 'Substring()'

            string name = "John Doe";

            int charPos = name.IndexOf("D");

            string lastName = name.Substring(charPos);

            Console.WriteLine(lastName);
        }
    }
}
