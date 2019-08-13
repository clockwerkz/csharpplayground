using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = 34.1;
            // double y = 56.4;
            // double res = x + y;
            // Console.WriteLine($"{x} + {y} = {res}");

            var numbers = new[] { 92.7, 90.3, 45.3 };

            if (args.Length > 0) {
                Console.WriteLine($"Hello, {args[0]}!");
            } else {
                Console.WriteLine("Hello!");
            }
        }
    }
}
