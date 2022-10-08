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
            SortArray test = new SortArray();

            test.SortExample();
            test.SortInt();
            test.Example2();

            Console.ReadLine();
        }
    }
}
