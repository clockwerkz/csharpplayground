using System;
using System.Collections.Generic;

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

            var grades = new List <double>() {56.1, 98.3, 83.0};
            var res = 0.0;
            foreach(double number in grades) {
                res += number;
            }
            res /= grades.Count;
            System.Console.WriteLine($"The average grade is {res:N1}.");

            if (args.Length > 0) {
                Console.WriteLine($"Hello, {args[0]}!");
            } else {
                Console.WriteLine("Hello!");
            }
        }
    }
}
