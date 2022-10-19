using System;

namespace SecondStep
{
    class Program
    {
        static void Main(string[] args)
        {
            Car3 Ford = new Car3();

            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car3 Opel = new Car3();

            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
