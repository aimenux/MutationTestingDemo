using System;
using Lib;

namespace App
{
    public static class Program
    {
        private static readonly Random Random = new Random(Guid.NewGuid().GetHashCode());

        public static void Main()
        {
            var x = Random.Next(1, 10_000);
            var y = Random.Next(1, 10_000);

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            var superComputer = new SuperComputer();

            var sum = superComputer.Sum(x, y);
            var sub = superComputer.Sub(x, y);
            var mul = superComputer.Mul(x, y);
            var div = superComputer.Div(x, y);

            Console.WriteLine($"x + y = {sum}");
            Console.WriteLine($"x - y = {sub}");
            Console.WriteLine($"x * y = {mul}");
            Console.WriteLine($"x / y = {div}");

            Console.WriteLine("Press any key to exit program !");
            Console.ReadKey();
        }
    }
}
