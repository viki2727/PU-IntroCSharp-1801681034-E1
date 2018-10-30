using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int f, s, t, g, r;
                Console.WriteLine("Enter first Number:");
                f = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second Number :");
                s = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Third Number:");
                t = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Fourth Number:");
                g = int.Parse(Console.ReadLine());
                r = (f + s + t + g ) / 4;
                Console.Write("Answer:  " + r);
                Console.ReadKey();







            }

               

        }
    }
}
