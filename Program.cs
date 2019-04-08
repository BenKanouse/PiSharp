using System;

namespace PiSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            decimal num;
            num = NextRandom(rand);
            Console.WriteLine(num);
            num = NextRandom(rand);
            Console.WriteLine(num);
        }

        static private decimal NextRandom(Random rand)
        {
            decimal big_number = 1_000_000_000;
            decimal num = rand.Next(0, 1_000_000_000) / big_number;
            return(num);
        }
    }
}
