using System;

namespace No._002_Dead_Ants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input ants string");
            var input = Console.ReadLine();
            Console.WriteLine(DeadAnts.GetDeadAntsCount(input));
        }
    }
}
