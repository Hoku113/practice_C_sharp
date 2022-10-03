using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstStep
{
    class Program
    {
        static void Main(string[] args)
        {
            /*クラスを読み込んで実装させる*/
            ShowDataTypes test = new ShowDataTypes();

            test.Numbers();
            test.ScientificNumbers();
            test.Booleans();
            test.Characters();
            test.Strings();

            Console.ReadLine();
        }
    }
}
