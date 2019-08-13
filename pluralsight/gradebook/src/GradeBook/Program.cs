using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args.Length > 0 ? args[0] : "Default";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
