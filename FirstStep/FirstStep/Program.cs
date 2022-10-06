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
            Access test = new Access();

            test.AccessStrings();
            test.ExtractsCharacters();

            Console.ReadLine();
        }
    }
}
