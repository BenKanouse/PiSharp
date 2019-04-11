using System;

namespace PiSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int simulations = 100_000_000;
            int inside_circle = 0;
            double x;
            double y;
            Random rand = new Random();

            for (int i = 0; i < simulations; i++)
            {
                x = NextRandom(rand);
                y = NextRandom(rand);
                if (Math.Sqrt(x * x + y * y) < 1)
                    inside_circle++;
            }
            Console.WriteLine(((double) inside_circle / simulations) * 4 );
        }

        static private double NextRandom(Random rand)
        {
            double big_number = 1_000_000_000;
            double num = rand.Next(0, 1_000_000_000) / big_number;
            return(num);
        }
    }
}
