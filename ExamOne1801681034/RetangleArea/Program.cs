using System;

namespace RetangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next(0,50);
            int y = rand.Next(51,100);
            int S = x * y;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"The retangle area is : {x} * {y} ={S}");

        }
    }
}
