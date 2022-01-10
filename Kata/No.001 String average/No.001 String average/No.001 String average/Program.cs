using System;
using System.Collections.Generic;
using System.Linq;

namespace No._001_String_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number string splite by space");
            var input = Console.ReadLine();
            Console.WriteLine(StringAverage.AverageString(input));
        }
    }
}
